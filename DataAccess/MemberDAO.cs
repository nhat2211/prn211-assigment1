using BusinessObject;
using System.Data;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<MemberObject> members = new List<MemberObject>();
        private static MemberDAO memberDAO=null;
        private static readonly object instanceLock = new object();

        private MemberDAO() { }

        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (memberDAO == null)
                    {
                        memberDAO = new MemberDAO();
                    }
                    return memberDAO;
                }
            }
            
        }

        public void insert(MemberObject member)
        {
            MemberObject existedMember = findById(member.MemberId);
            if (existedMember != null) {
                throw new Exception("Member already existed!");

            }
            else
            {
                members.Add(member);
            }
           

        }

        public List<MemberObject> findAll()
        {
            return members;

        }

        public MemberObject findById(string id)
        {
            return members.Find(m => m.MemberId.Equals(id));
        }

        public MemberObject findByIdAndName(string id, string name)
        {
            return members.Find(m => m.MemberId.Equals(id)
            && m.MemberName.Equals(name));
        }

        public void update(MemberObject member)
        {
            MemberObject exixtedMember = findById(member.MemberId);
            if (exixtedMember != null)
            {
                members[members.IndexOf(exixtedMember)] = member;
            }
            else
            {
                throw new Exception("Member not existed");
            }

        }
        public void remove(string id)
        {
            MemberObject existedMember = findById(id);
            if(existedMember == null) throw new Exception("Member not existed");
            members.Remove(existedMember);    
        }

    }
}