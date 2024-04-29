using Microsoft.AspNetCore.Mvc;

namespace modul10_1302223019.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static readonly List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Puri Lalita Anagata", "1302223019", new List<string> {"PBO, Basis Data, Proting"}, 2022),
            new Mahasiswa("Rd. M. Faisal Ramadhan Junaidi", "1302220093", new List < string > { "PBO, Proting,Basis Data" }, 2023),
            new Mahasiswa("Muhammad Fajar Mufid", "1302223032", new List < string > { "Alpro, UX, Proting" }, 2004),
            new Mahasiswa("Arga Adolf Lumunon", "1302223038", new List < string > { "Proting, KPL, PBO" }, 2021),
            new Mahasiswa("Gina Soraya", "1302223070", new List < string > { "PBO, KPL, Basdat" }, 2025),
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(daftarMahasiswa);
        }

        [HttpPost]
        public IActionResult Create(Mahasiswa mahasiswa)
        {
            daftarMahasiswa.Add(mahasiswa);
            return CreatedAtAction(nameof(GetById), new { id = daftarMahasiswa.IndexOf(mahasiswa) }, mahasiswa);
        }

        [HttpPost("{id}")]
        public IActionResult GetById(int id)
        {
            if (id < 0 || id >= daftarMahasiswa.Count)
            {
                return NotFound();
            }
            return Ok(daftarMahasiswa[id]);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= daftarMahasiswa.Count)
            {
                return NotFound();
            }
            daftarMahasiswa.RemoveAt(id);
            return NoContent();
        }
    }
}