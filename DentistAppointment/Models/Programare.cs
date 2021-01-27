using System;
namespace DentistAppointment
{
    public class Programare
    {
        public int ProgrameId { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int CabinetId { get; set; }
        public Cabinet Cabinet { get; set; }
    }
}