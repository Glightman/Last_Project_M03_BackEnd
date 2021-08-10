using CarStore.Models;
using System.Collections.Generic;

namespace CarStore.Services
{
    public interface ITesteDriveService
    {
        bool create(TesteDrive teste);
        bool delete(int? id);
        TesteDrive get(int? id);
        List<TesteDrive> getAll();
        bool update(TesteDrive t);
    }
}