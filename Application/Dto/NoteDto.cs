using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class NoteDto
    {
        //tutaj zwracamy tylko to co chcemy
        public int Id { get; set; }
        public string Title { get; set; }
        public string Context { get; set; }


    }
}
