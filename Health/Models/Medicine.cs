﻿using Health.Services;
using System;
using System.Collections.Generic;
using System.Linq;

/*
 * @author: Victor Noe Hernández
 * @version: 1.0.0
 * @description: class for medicine objects
 */

namespace Health.Models {
    public class Medicine {
        
        public int idMedicine { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public String producer { get; set; }
        public double price { get; set; }
        public int stock { get; set; }


        public Medicine(){}

        public bool saveMedicine(bool structure){
            try {
                if (structure) {
                    Storage.Instance.treeList.addValue(this, Medicine.CompareByName);
                } else {
                    Storage.Instance.medicinesList.Add(this);
                }
                return true;
            }catch{
                return false;
            }
        }

        public bool deleteMedicine(){
            try {
                Storage.Instance.treeList.deleteValue(this, Medicine.CompareByName);
                return true;
            }catch{
                return false;
            }
        }

        public static Comparison<Medicine> CompareByName = delegate (Medicine medicine_one, Medicine medicine_two) {
            return medicine_one.name.ToLower().CompareTo(medicine_two.name.ToLower());
        };
    }
}