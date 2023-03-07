namespace Checkboxes2.Models {
    public class PersonViewModel {
        public int PersonId { get; set; }
        public string? Name { get; set; }
        public List<Skill>? Skills { get; set; }

        public List<string>? MySkills { get; set; }
    }
}