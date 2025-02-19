using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoExamen.domain;

namespace proyectoExamen.persistence.manages
{
    /// <summary>
    /// Class ManagesBook.
    /// </summary>
    internal class ManagesBook
    {

        /// <summary>
        /// The dbbroker
        /// </summary>
        DBBroker dbbroker;
        /// <summary>
        /// The list book
        /// </summary>
        List<Book> listBook;
        /// <summary>
        /// The last identifier
        /// </summary>
        int lastId;

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagesBook"/> class.
        /// </summary>
        public ManagesBook()
        {
            dbbroker = DBBroker.obtenerAgente();
            listBook = new List<Book>();
        }

        /// <summary>
        /// Gets the last identifier.
        /// </summary>
        /// <param name="book">The book.</param>
        /// <returns>System.Int32.</returns>
        public int getLastId(Book book)
        {
            List<Object> listaAux;
            listaAux = DBBroker.obtenerAgente().leer("SELECT COALESCE(MAX(idBook), 0) FROM bbddClubLectura.Book");

            foreach (List<Object> aux in listaAux)
            {
                lastId = Convert.ToInt32(aux[0]) + 1;
            }
            return lastId;
        }


        /// <summary>
        /// Reads the book.
        /// </summary>
        /// <returns>List&lt;Book&gt;.</returns>
        public List<Book> readBook()
        {
            List<Object> listaAux = DBBroker.obtenerAgente().leer("SELECT * FROM bbddClubLectura.Book");
            foreach (List<Object> aux in listaAux)
            {
                Book book = new Book(Convert.ToInt32(aux[0]), aux[1].ToString(), aux[2].ToString(), Convert.ToDateTime(aux[3]), Convert.ToInt32(aux[4]) );
                listBook.Add(book);
            }
            return listBook;
        }


        /// <summary>
        /// Inserts the book.
        /// </summary>
        /// <param name="book">The book.</param>
        public void insertBook(Book book)
        {
            dbbroker.modificar("Insert into bbddClubLectura.Book values (" + book.IdBook + ", '" + book.TitleBook + "', '" + book.AuthorBook + "', '" + book.PublicationYearBook.ToString("yyyy-MM-dd")+"', "+book.IdGender+") ");
        }

        /// <summary>
        /// Modifies the book.
        /// </summary>
        /// <param name="book">The book.</param>
        public void modifyBook(Book book)
        {
            dbbroker.modificar("Update bbddClubLectura.Book set titleBook = '"+book.TitleBook+"', authorBook = '"+book.AuthorBook+"', PublicationYearBook = '"+book.PublicationYearBook.ToString("yyyy-MM-dd")+"' where idBook = "+book.IdBook+" ");
        }


        /// <summary>
        /// Deletes the book.
        /// </summary>
        /// <param name="book">The book.</param>
        public void deleteBook(Book book)
        {
            dbbroker.modificar("Delete from bbddClubLectura.Book where idBook = " + book.IdBook + " ");

        }
    }
}

