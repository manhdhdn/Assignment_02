using BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private readonly DataContext _context = new();

        public static bool Login(string email, string password)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string AdEmail = configuration["Admin:Email"];
            string AdPassword = configuration["Admin:Password"];

            if (email == AdEmail && password == AdPassword)
            {
                return true;
            }

            return false;
        }

        public IEnumerable<Member> GetMembers()
        {
            if (_context.Members == null)
            {
                throw new Exception("Connection failed.");
            }

            return _context.Members.OrderBy(m => m.MemberId).ToList();
        }

        public Member GetMember(int memberId, string? email, string? password)
        {
            if (_context.Members == null)
            {
                throw new Exception("Connection failed.");
            }

            Member member = null!;

            if (email == null)
            {
                member = _context.Members.Find(memberId)!;
            }
            else
            {
                member = _context.Members.FirstOrDefault(m => m.Email == email && m.Password == password)!;
            }

            if (member == null)
            {
                throw new Exception("Not found.");
            }

            return member;
        }

        public void InsertMember(Member member)
        {
            if (_context.Members == null)
            {
                throw new Exception("Connection failed.");
            }

            _context.Members.Add(member);

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateMember(Member member)
        {
            if (_context.Members == null)
            {
                throw new Exception("Connection failed.");
            }

            _context.Entry(member).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteMember(int memberId)
        {
            if (_context.Members == null)
            {
                throw new Exception("Connection failed.");
            }

            var member = _context.Members.Find(memberId);

            if (member == null)
            {
                throw new Exception("Not found.");
            }

            _context.Remove(member);
            _context.SaveChanges();
        }
    }
}
