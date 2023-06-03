IService service = new Service();
var controller = new Controller(service);

class Controller
{
    private readonly IService _service;

    public Controller(IService service)
    {
        _service = service;
    }
}

class Service : IService
{

}

interface IService
{

}