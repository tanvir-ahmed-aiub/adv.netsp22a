using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class TokenRepo : IRepository<Token, string>,IAuth<Token>
    {
        UMS_Sp22_AEntities db;
        public TokenRepo(UMS_Sp22_AEntities db)
        {
            this.db = db;
        }
        public bool Add(Token obj)
        {
            db.Tokens.Add(obj);
            if (db.SaveChanges() != 0) return true;
            return false;

        }

        public Token Authenticate(string uname, string pass)
        {
            var data = db.Users.FirstOrDefault(x => x.Username.Equals(uname) && x.Password.Equals(pass));
            if (data != null) {
                var token = new Token();
                token.Tkey = "dsfdfgf";//random string
                token.CreatedAt = DateTime.Now;
                token.UserId = data.Id;
                token.ExpiredAt = null;
                if (this.Add(token)) return token;
                
            }
            return null;
            
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Token obj)
        {
            throw new NotImplementedException();
        }

        public Token Get(string tKey)
        {
            return db.Tokens.FirstOrDefault(e => e.Tkey.Equals(tKey));
        }

        public List<Token> Get()
        {
            throw new NotImplementedException();
        }
    }
}
