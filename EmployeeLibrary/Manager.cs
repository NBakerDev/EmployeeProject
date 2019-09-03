using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLibrary {
   public class Manager : Employee {
        private int TeamSize = 0;

        public override string Print() {
            return base.Print() + $" Team Size: {TeamSize}";
                }


        public Manager(string name, string job, decimal salary, int teamsize) : base(name, job, salary) {
            this.TeamSize = teamsize;
        }

        }
    }

