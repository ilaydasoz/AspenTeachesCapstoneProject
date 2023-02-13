using System;
namespace DTOLayer.DTOs.InstructorDTOs
{
    public class InstructorAddDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string GithubUrl { get; set; }
        public string LinkedinUrl { get; set; }
        public string Image { get; set; }
    }
}
