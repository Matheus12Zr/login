using login.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace login.imagens
{
     public interface Musica
    {
        bool AuthenticateUser(NetworkCredential credential);
        void Add(UperModel uperModel);
        void Edit(UperModel uperModel);
        void Remove(int id);
        UperModel GetById(int id);
        UperModel GetByUsername(string username);
        IEnumerable<UperModel> GetAll();
    }
}
