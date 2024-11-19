    using AutoMapper;
    using EmployeeCrudApp.RequestModels.Employee;

    namespace EmployeeCrudApp.MappingProfile
    {
        public class MappingProfiles: Profile
        {
            public MappingProfiles()
            {
            
                CreateMap<GetAllEmployeRequestModel, AddEmployeeRequestModel>();
            }
        }
    }
