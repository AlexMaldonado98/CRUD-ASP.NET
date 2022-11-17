using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
    public class Class1
    {
        ticketsEntities db = new ticketsEntities();

        public List<Tickets.tickets> Listar()
        {
            var tickets = from a in db.tickets
                          select a;
            return tickets.ToList();
        }

        public Tickets.tickets Buscar(int id)
        {
            var tickets = from a in db.tickets
                          where a.id == id
                          select a;
            return tickets.FirstOrDefault();
        }

        public void Modificar(tickets item)
        {
            var ticket = (from a in db.tickets
                           where a.id == item.id
                           select a).FirstOrDefault();
            ticket.nombre = item.nombre;
            ticket.descripcion = item.descripcion;
            ticket.departamento = item.departamento;
            db.SaveChanges();
        }

        public void Agregar(tickets item)
        {
            Console.WriteLine(item);
            db.tickets.Add(item);
            db.SaveChanges();
        }

        public void Delete(tickets item)
        {
            var ticket = (from a in db.tickets
                           where a.id == item.id
                           select a).FirstOrDefault();
            db.tickets.Remove(ticket);
            db.SaveChanges();
        }
    }
}
