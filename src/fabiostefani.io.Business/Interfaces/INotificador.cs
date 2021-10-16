using fabiostefani.io.Business.Notificacoes;
using System.Collections.Generic;

namespace fabiostefani.io.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
