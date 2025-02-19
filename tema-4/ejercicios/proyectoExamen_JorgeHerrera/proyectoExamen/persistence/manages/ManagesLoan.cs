using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoExamen.domain;

namespace proyectoExamen.persistence.manages
{
    /// <summary>
    /// Class ManagesLoan.
    /// </summary>
    internal class ManagesLoan
    {

        /// <summary>
        /// The d b broker
        /// </summary>
        DBBroker dBBroker;
        /// <summary>
        /// The list loan
        /// </summary>
        List<Loan> listLoan;
        /// <summary>
        /// The last identifier
        /// </summary>
        int lastId;


        /// <summary>
        /// Initializes a new instance of the <see cref="ManagesLoan"/> class.
        /// </summary>
        public ManagesLoan()
        {
            dBBroker = DBBroker.obtenerAgente();
            listLoan = new List<Loan>();
        }

        /// <summary>
        /// Reads the loan.
        /// </summary>
        /// <returns>List&lt;Loan&gt;.</returns>
        public List<Loan> readLoan()
        {
            List<Object> listaAux = DBBroker.obtenerAgente().leer("SELECT * FROM bbddClubLectura.Loan");
            foreach (List<Object> aux in listaAux)
            {

                Loan loan = new Loan(Convert.ToDateTime(aux[0]), Convert.ToDateTime(aux[1]), Convert.ToInt32(aux[2]), Convert.ToInt32(aux[3]) );
                listLoan.Add(loan);

            }
            return listLoan;
        }


        /// <summary>
        /// Inserts the loan.
        /// </summary>
        /// <param name="loan">The loan.</param>
        public void insertLoan(Loan loan)
        {
            dBBroker.modificar("Insert into bbddClubLectura.Loan values ('" +loan.LoanDate.ToString("yyyy-MM-dd")+"', '"+loan.ReturnDate.ToString("yyyy-MM-dd")+"', " + loan.IdMember + ", " + loan.IdBook + ") ");
        }
    }
}
