using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoExamen.persistence.manages;

namespace proyectoExamen.domain
{
    /// <summary>
    /// Class Member.
    /// </summary>
    internal class Member
    {

        /// <summary>
        /// The identifier member
        /// </summary>
        private int idMember;
        /// <summary>
        /// The name member
        /// </summary>
        private string nameMember;
        /// <summary>
        /// The birth member
        /// </summary>
        private DateTime birthMember;
        /// <summary>
        /// The email member
        /// </summary>
        private string emailMember;
        /// <summary>
        /// The telephone member
        /// </summary>
        private int telephoneMember;

        /// <summary>
        /// The next identifier
        /// </summary>
        private static int nextId = 1;

        /// <summary>
        /// The mm
        /// </summary>
        public ManagesMember mm;

        /// <summary>
        /// The list members
        /// </summary>
        public List<Member> listMembers;

        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class.
        /// </summary>
        /// <param name="idMember">The identifier member.</param>
        /// <param name="nameMember">The name member.</param>
        /// <param name="birthMember">The birth member.</param>
        /// <param name="emailMember">The email member.</param>
        /// <param name="telephoneMember">The telephone member.</param>
        public Member(int idMember, string nameMember, DateTime birthMember, string emailMember, int telephoneMember)
        {
            mm = new ManagesMember();

            this.idMember = idMember;
            this.nameMember = nameMember;
            this.birthMember = birthMember;
            this.emailMember = emailMember;
            this.telephoneMember = telephoneMember;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class.
        /// </summary>
        /// <param name="nameMember">The name member.</param>
        /// <param name="birthMember">The birth member.</param>
        /// <param name="emailMember">The email member.</param>
        /// <param name="telephoneMember">The telephone member.</param>
        public Member(string nameMember, DateTime birthMember, string emailMember, int telephoneMember)
        {
            mm = new ManagesMember();

            this.idMember = mm.getLastId(this);
            this.nameMember = nameMember;
            this.birthMember = birthMember;
            this.emailMember = emailMember;
            this.telephoneMember = telephoneMember;

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class.
        /// </summary>
        public Member()
        {
            mm = new ManagesMember();
        }

        /// <summary>
        /// Gens the lista members.
        /// </summary>
        /// <returns>List&lt;Member&gt;.</returns>
        public List<Member> genListaMembers()
        {
            listMembers = mm.readMembers();

            if (listMembers.Any())
            {

                nextId = listMembers.Max(m => m.IdMember) + 1;

            }

            return listMembers;
        }

        /// <summary>
        /// Inserts the member.
        /// </summary>
        public void insertMember()
        {
            mm.insertMember(this);
        }
        /// <summary>
        /// Deletes the member.
        /// </summary>
        public void deleteMember()
        {
            mm.deleteMember(this);
        }

        /// <summary>
        /// Modifies the member.
        /// </summary>
        public void modifyMember()
        {
            mm.modifyMember(this);

        }

        /// <summary>
        /// Gets or sets the identifier member.
        /// </summary>
        /// <value>The identifier member.</value>
        public int IdMember { get => idMember; set => idMember = value; }
        /// <summary>
        /// Gets or sets the name member.
        /// </summary>
        /// <value>The name member.</value>
        public string NameMember { get => nameMember; set => nameMember = value; }
        /// <summary>
        /// Gets or sets the birth member.
        /// </summary>
        /// <value>The birth member.</value>
        public DateTime BirthMember { get => birthMember; set => birthMember = value; }
        /// <summary>
        /// Gets or sets the email member.
        /// </summary>
        /// <value>The email member.</value>
        public string EmailMember { get => emailMember; set => emailMember = value; }
        /// <summary>
        /// Gets or sets the telephone member.
        /// </summary>
        /// <value>The telephone member.</value>
        public int TelephoneMember { get => telephoneMember; set => telephoneMember = value; }

    }
}
