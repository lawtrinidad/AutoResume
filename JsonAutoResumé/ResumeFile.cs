namespace JsonAutoResumé
{
    class ResumeFile
    {

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Birthdate { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<string> Education { get; set; }
        public string Description { get; set; }
        public List<string> Skills { get; set; }

        public override string ToString()
        {
            return string.Format("First Name: {0}\nMiddle Name: {1}\nLast Name: {2}\nBirthdate: {3}\nAddress: {4}\nEmail: {5}\nPhone Number: {6}\nEducation: {7}\nDescription: {8}\nSkills: {9}", FirstName, MiddleName, LastName, Birthdate, Address, Email, PhoneNumber, string.Join(",", Education.ToArray()), Description, string.Join(",", Skills.ToArray()));

        }
    }
}