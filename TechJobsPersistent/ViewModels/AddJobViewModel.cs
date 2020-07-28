using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Job's name is required")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Employer is required")]
        public int EmployerId { get; set; }

        public List<SelectListItem> Employers { get; set; }

        public void setEmployers(List<Employer> employers)
        {
            Employers = new List<SelectListItem>();
            foreach (var employer in employers)
            {
                Employers.Add(
                    new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Name
                    }
                 );
            }
        }

        public List<int> SkillIds { get; set; }

        public List<Skill> Skills { get; set; }

        /*public void setSkills(List<Skill> skills)
        {
            Skills = new List<SelectListItem>();
            foreach (var skill in skills)
            {
                Skills.Add(
                    new SelectListItem
                    {
                        Value = skill.Id.ToString(),
                        Text = skill.Name
                    }
                 );
            }
        }
        */

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            setEmployers(employers);
            Skills = skills;
        }

        public AddJobViewModel() { }

    }
}
