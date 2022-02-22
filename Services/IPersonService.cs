using Ass_9.Models;

namespace Ass_9.Services;

public interface IPersonService{
    List<Person> GetAll();
    Person GetOne(int index);
    Person Create(Person person);
    Person Update(int index , Person person);
    void Delete(int index);

    
}