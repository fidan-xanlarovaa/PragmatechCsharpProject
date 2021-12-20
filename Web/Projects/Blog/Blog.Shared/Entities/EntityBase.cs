using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Shared.Entities
{
    /// <summary>
    /// Butun domainlerimiz burdan toreyecek 
    ///                          Yaranma meqsedi:
                                      /* 1.Struktur meselesi sonra butun classlarimiza ne ise bir ozellik elave etmek isteek hamsi burdan
                                       toreyib deye rahat elave ede bileceyik
                                       2. Abstarct olduqu ucun ondan instance ala bilmirik,sirf base class kimi istifade edirik*/
    /// </summary>
    public abstract class EntityBase //
    {


        protected EntityBase()
        {

        }

        protected EntityBase(string note) : this()
        {
            this.Note = note;
        }
        /// <summary>
        /// virtual keyword ile biz bunu overwrite ede bilerik
        /// </summary>
        public virtual int Id { get; set; }
        [Required]

        public virtual bool IsActive { get; private set; } = true; //Bloq paylasilacaq deye, hansi bloglar activdise onlar gorsensin
        [Required]

        public virtual bool IsDeleted { get; private set; } = false; //Biz eslinde delete emeliyyatinda neyise silmekden qaciniriq deye isdeleted=true edirik ve
        [Required]
                                                                     //onu silinmis kimi gorsedirik. Amma eslinde database de o melumat qalmis olur

                                                                    // Yuxarida__ private set __yazmisiq deye hec kim colden onu true ve ya false ede bilmir,
                                                                    // yalniz metodlar vasitesi ile deyise bilirik
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        [Required]

        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        [MaxLength(500)]

        public virtual string Note { get; set; }
        [Required]


        public virtual string CreatedByName { get; private set; } = "Admin";
        [Required]

        public virtual string ModifiedByName { get; private set; } = "Admin";



        // methods
        public void SetIsActive(bool isActive)
        {
            this.IsActive = isActive;
        }
        public void SetIsDeleted(bool isDeleted)
        {
            this.IsDeleted = isDeleted;
        }
        public void SetCreatedByName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                this.CreatedByName = name;
            }
        }
        public void SetModifiedByName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                this.ModifiedByName = name;
            }
        }

        public void SetNote(string note)
        {
            if (!string.IsNullOrEmpty(note))
            {
                this.Note = note;
            }
        }
    }
}




