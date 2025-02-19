using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoExamen.persistence.manages;

namespace proyectoExamen.domain
{
    /// <summary>
    /// Class Book.
    /// </summary>
    internal class Book
    {
        /// <summary>
        /// The identifier book
        /// </summary>
        private int idBook;
        /// <summary>
        /// The title book
        /// </summary>
        private string titleBook;
        /// <summary>
        /// The author book
        /// </summary>
        private string authorBook;
        /// <summary>
        /// The publication year book
        /// </summary>
        private DateTime publicationYearBook;
        /// <summary>
        /// The identifier gender
        /// </summary>
        private int idGender;

        /// <summary>
        /// The next identifier
        /// </summary>
        private static int nextId = 1;

        /// <summary>
        /// The mb
        /// </summary>
        public ManagesBook mb;

        /// <summary>
        /// The list books
        /// </summary>
        public List<Book> listBooks;

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        /// <param name="idBook">The identifier book.</param>
        /// <param name="titleBook">The title book.</param>
        /// <param name="authorBook">The author book.</param>
        /// <param name="publicationYear">The publication year.</param>
        /// <param name="idGender">The identifier gender.</param>
        public Book(int idBook, string titleBook, string authorBook, DateTime publicationYear, int idGender)
        {
            mb = new ManagesBook();

            this.idBook = idBook;
            this.titleBook = titleBook;
            this.authorBook = authorBook;
            this.publicationYearBook = publicationYear;
            this.idGender = idGender;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        public Book()
        {
            mb = new ManagesBook();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        /// <param name="titleBook">The title book.</param>
        /// <param name="authorBook">The author book.</param>
        /// <param name="publicationYear">The publication year.</param>
        public Book(string titleBook, string authorBook, DateTime publicationYear)
        {
            mb = new ManagesBook();

            this.idBook = mb.getLastId(this);
            this.titleBook = titleBook;
            this.authorBook = authorBook;
            this.publicationYearBook = publicationYear;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        /// <param name="titleBook">The title book.</param>
        /// <param name="authorBook">The author book.</param>
        /// <param name="publicationYear">The publication year.</param>
        /// <param name="idGender">The identifier gender.</param>
        public Book(string titleBook, string authorBook, DateTime publicationYear, int idGender)
        {
            mb = new ManagesBook();

            this.idBook = mb.getLastId(this);
            this.titleBook = titleBook;
            this.authorBook = authorBook;
            this.publicationYearBook = publicationYear;
            this.idGender = idGender;
        }


        /// <summary>
        /// Gens the lista books.
        /// </summary>
        /// <returns>List&lt;Book&gt;.</returns>
        public List<Book> genListaBooks()
        {
            listBooks = mb.readBook();

            if (listBooks.Any())
            {

                nextId = listBooks.Max(b => b.IdBook) + 1;

            }

            return listBooks;
        }

        /// <summary>
        /// Inserts the book.
        /// </summary>
        public void insertBook()
        {
            mb.insertBook(this); 
        }


        /// <summary>
        /// Modifies the book.
        /// </summary>
        public void modifyBook()
        {
            mb.modifyBook(this);
        }

        /// <summary>
        /// Deletes the book.
        /// </summary>
        public void deleteBook()
        {
            mb.deleteBook(this);
        }


        /// <summary>
        /// Gets or sets the identifier book.
        /// </summary>
        /// <value>The identifier book.</value>
        public int IdBook { get => idBook; set => idBook = value; }
        /// <summary>
        /// Gets or sets the title book.
        /// </summary>
        /// <value>The title book.</value>
        public string TitleBook { get => titleBook; set => titleBook = value; }
        /// <summary>
        /// Gets or sets the author book.
        /// </summary>
        /// <value>The author book.</value>
        public string AuthorBook { get => authorBook; set => authorBook = value; }
        /// <summary>
        /// Gets or sets the publication year book.
        /// </summary>
        /// <value>The publication year book.</value>
        public DateTime PublicationYearBook { get => publicationYearBook; set => publicationYearBook = value; }
        /// <summary>
        /// Gets or sets the identifier gender.
        /// </summary>
        /// <value>The identifier gender.</value>
        public int IdGender { get => idGender; set => idGender = value; }


    }
}
