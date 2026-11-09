using ServiceContracts;
namespace LearningServicesClassLib;

public class CitiesService : ICitiesService
{
    private List<string> _cities ;
    public CitiesService()
    {
        _cities = new List<string>()
        {
            "Hyderabad",
            "Nizambad",
            "Armoor",
            "Nizamsagar",
            "Yellareddy",
        };
    }

    public List<string> Cities
    {
        get
        {
            return _cities;
        }
        set
        {
            _cities = value;
        }
    }


}
