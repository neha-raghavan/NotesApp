using NotesApp.Models;
using System;

namespace NotesApp.Services
{
 
        public class NoteService : INoteService
        {
            private readonly DatabaseContext _ctx;
            public NoteService(DatabaseContext ctx)
            {
                _ctx = ctx;
            }


        public bool AddUpdate(Note note)
        {
            try
            {
                if (note.Note_Id == 0)
                    _ctx.Notes.Add(note);
                else
                    _ctx.Notes.Update(note);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var note = FindById(id);
                if (note == null)
                    return false;
                _ctx.Notes.Remove(note);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public Note FindById(int id)
        {
            return _ctx.Notes.Find(id);
        }
        public List<Note> GetAll()
            {
                return _ctx.Notes.ToList();
            }
        }
 }

