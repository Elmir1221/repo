using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coures_Application.Controller
{
    public class EducationController: IEduca
    {


        private readonly IEducationService _educationService;


        public EducationController()
        {
            _educationService = new EducationService();
        }



    }
}
