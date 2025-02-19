using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoExamen.domain;

namespace proyectoExamen.persistence.manages
{
    /// <summary>
    /// Class ManagesMember.
    /// </summary>
    internal class ManagesMember
    {

        /// <summary>
        /// The dbbroker
        /// </summary>
        DBBroker dbbroker;
        /// <summary>
        /// The list member
        /// </summary>
        List<Member> listMember;
        /// <summary>
        /// The last identifier
        /// </summary>
        int lastId;

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagesMember"/> class.
        /// </summary>
        public ManagesMember()
        {
            dbbroker = DBBroker.obtenerAgente();
            listMember = new List<Member>();
        }

        /// <summary>
        /// Gets the last identifier.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <returns>System.Int32.</returns>
        public int getLastId(Member member)
        {
            List<Object> listaAux;
            listaAux = DBBroker.obtenerAgente().leer("SELECT COALESCE(MAX(idMember), 0) FROM bbddClubLectura.Member");

            foreach (List<Object> aux in listaAux)
            {
                lastId = Convert.ToInt32(aux[0]) + 1;
            }
            return lastId;
        }

        /// <summary>
        /// Reads the members.
        /// </summary>
        /// <returns>List&lt;Member&gt;.</returns>
        public List<Member> readMembers()
        {
            List<Object> listaAux = DBBroker.obtenerAgente().leer("SELECT * FROM bbddClubLectura.Member");
            foreach (List<Object> aux in listaAux)
            {
                Member member = new Member(Convert.ToInt32(aux[0]), aux[1].ToString(), Convert.ToDateTime(aux[2]), aux[3].ToString(), Convert.ToInt32(aux[4]));
                listMember.Add(member);
            }
            return listMember;
        }

        /// <summary>
        /// Inserts the member.
        /// </summary>
        /// <param name="member">The member.</param>
        public void insertMember(Member member)
        {
            dbbroker.modificar("Insert into bbddClubLectura.Member values ("+member.IdMember+", '"+member.NameMember+"', '"+member.BirthMember.ToString("yyyy-MM-dd")+"', '"+member.EmailMember+"', "+member.TelephoneMember+" )");                                                          
        }

        /// <summary>
        /// Deletes the member.
        /// </summary>
        /// <param name="member">The member.</param>
        public void deleteMember(Member member)
        {
            dbbroker.modificar("Delete from bbddClubLectura.Member where idMember = " + member.IdMember + "");
        }

        /// <summary>
        /// Modifies the member.
        /// </summary>
        /// <param name="member">The member.</param>
        public void modifyMember(Member member)
        {
            dbbroker.modificar("Update bbddClubLectura.Member SET nameMember = '" + member.NameMember + "', birthMember = '" + member.BirthMember.ToString("yyyy-MM-dd") + "', emaiMember = '" + member.EmailMember + "', telephoneMember = " + member.TelephoneMember + " where idMember = "+member.IdMember+" ");                                                       
        }
    }
}
