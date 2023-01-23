using NotesApp.Models;
using System;

namespace NotesApp.Services
{
    public interface INoteService
    {

        bool AddUpdate(Note note);
        bool Delete(int id);
        Note FindById(int id);
        List<Note> GetAll();
    }
}
