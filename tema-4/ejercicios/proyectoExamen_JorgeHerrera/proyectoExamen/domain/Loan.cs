using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoExamen.persistence.manages;

namespace proyectoExamen.domain
{
    /// <summary>
    /// Class Loan.
    /// </summary>
    internal class Loan
    {

        /// <summary>
        /// The loan date
        /// </summary>
        private DateTime loanDate;
        /// <summary>
        /// The return date
        /// </summary>
        private DateTime returnDate;
        /// <summary>
        /// The identifier member
        /// </summary>
        private int idMember;
        /// <summary>
        /// The identifier book
        /// </summary>
        private int idBook;

        /// <summary>
        /// The next identifier
        /// </summary>
        private static int nextId = 1;

        /// <summary>
        /// The ml
        /// </summary>
        public ManagesLoan ml;

        /// <summary>
        /// The list loan
        /// </summary>
        public List<Loan> listLoan;


        /// <summary>
        /// Initializes a new instance of the <see cref="Loan"/> class.
        /// </summary>
        /// <param name="loanDate">The loan date.</param>
        /// <param name="returnDate">The return date.</param>
        /// <param name="idMember">The identifier member.</param>
        /// <param name="idBook">The identifier book.</param>
        public Loan(DateTime loanDate, DateTime returnDate, int idMember, int idBook)
        {

            ml = new ManagesLoan();

            this.loanDate = loanDate;
            this.returnDate = returnDate;
            this.idMember = idMember;
            this.idBook = idBook;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Loan"/> class.
        /// </summary>
        public Loan()
        {
            ml = new ManagesLoan();
        }


        /// <summary>
        /// Gens the lista loans.
        /// </summary>
        /// <returns>List&lt;Loan&gt;.</returns>
        public List<Loan> genListaLoans()
        {
            listLoan = ml.readLoan();

            if (listLoan.Any())
            {

                nextId = listLoan.Max(l => l.IdBook) + 1;

            }

            return listLoan;
        }

        /// <summary>
        /// Inserts the loan.
        /// </summary>
        public void insertLoan()
        {
            ml.insertLoan(this);
        }

        /// <summary>
        /// Gets or sets the loan date.
        /// </summary>
        /// <value>The loan date.</value>
        public DateTime LoanDate { get => loanDate; set => loanDate = value; }
        /// <summary>
        /// Gets or sets the return date.
        /// </summary>
        /// <value>The return date.</value>
        public DateTime ReturnDate { get => returnDate; set => returnDate = value; }
        /// <summary>
        /// Gets or sets the identifier member.
        /// </summary>
        /// <value>The identifier member.</value>
        public int IdMember { get => idMember; set => idMember = value; }
        /// <summary>
        /// Gets or sets the identifier book.
        /// </summary>
        /// <value>The identifier book.</value>
        public int IdBook { get => idBook; set => idBook = value; }
    }
}
