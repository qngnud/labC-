﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HE130007_KhoiTran_Lab3.DTL;

namespace HE130007_KhoiTran_Lab3.DAL
{
    class BorrowerDAO
    {
        public static DataTable GetDataTable()
        {
            string cmd = "select * from Borrower";
            return DAO.GetDataTable(cmd);
        }

      internal static Borrower GetBorrower(int borrowerNumber) {
         throw new NotImplementedException();
      }
   }
}
