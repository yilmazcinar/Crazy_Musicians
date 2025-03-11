using Crazy_Musicians.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crazy_Musicians.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MusicianControllers : ControllerBase
{
    private static readonly List<Musician> _musicians = new List<Musician>
    {
         new Musician{ Id = 1, FullName = "Ahmet Çalgı", Skill = "Ünlü Çalgı Çalar", FunFeature = "Her zaman yanlış nota çalar, ama çok eğlenceli"},
            new Musician{ Id = 2, FullName = "Zeynep Melodi", Skill = "Popüler Melodi Yazan", FunFeature = "Şarkıları yanlış anlaşılır ama çok popüler"},
            new Musician{ Id = 3, FullName = "Cemil Akor", Skill = "Çılgın Akorist", FunFeature = "Akorlan sık değiştirir, ama şaşırtıcı derecede yetenekli"},
            new Musician{ Id = 4, FullName = "Fatma Nokta", Skill = "Sürpriz Nota Üreticisi", FunFeature = "Nota üretirken sürekli sürprizler hazırlar"},
            new Musician{ Id = 5, FullName = "Hasan Ritim", Skill = "Ritim Canavarı", FunFeature = "Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir"},
            new Musician{ Id = 6, FullName = "Elif Armoni", Skill = "Armoni Ustası", FunFeature = "Armonilerini bazen yanlış çalar, ama çok yaratıcıdır"},
            new Musician{ Id = 7, FullName = "Ali Perde", Skill = "Perde Uygulayıcı", FunFeature = "Her perdeyi farklı şekilde çalar, her zaman sürprizlidir"},
            new Musician{ Id = 8, FullName = "Ayşe Rezonans", Skill = "Rezonans Uzmanı", FunFeature = "Rezonans konusunda uzman ama bazen çok gürültü çıkarır"},
            new Musician{ Id = 9, FullName = "Murat Ton", Skill = "Tonlama Meraklısı", FunFeature = "Tonlamalarındaki farklılıklar bazen komik, ama oldukça ilginç"},
            new Musician{ Id = 10, FullName = "Selin Akor", Skill = "Akor Sihirbazı", FunFeature = "Akorlan değiştirdiğinde bazen sihirli bir hava yaratır"}


    };

    [HttpGet]

    public IActionResult GetAll()
    {
        return Ok(_musicians);
    }


    [HttpGet("{id}")]

    public IActionResult Get(int id)
    {
        var musician = _musicians.FirstOrDefault(x => x.Id == id);

        if (musician is null)
        {
            return NotFound("yok böyle bir müzisyen");
        }
        
        return Ok(musician);

    }

    [HttpPost]

    public IActionResult Add(Musician musician)
    {
        var musicianId = _musicians.Max(x => x.Id) + 1;
        
        
        musician.Id = musicianId;

        _musicians.Add(musician);
        
        return CreatedAtAction(nameof(Get), new { id = musician.Id }, musician);
    }


    [HttpPut("{id}")]

    public IActionResult Update(int id, MusicianUpdate update)
    {

        var musician = _musicians.FirstOrDefault(x => x.Id == id);

        if (musician is null) 
        {

            return NotFound("Yok böyle bir müzisyen");
            

        }

        musician.FullName = update.FullName;
        musician.Skill = update.Skill;
        musician.FunFeature = update.FunFeature;

        return Ok(musician);

    }

    [HttpPatch("{id}")]

    public IActionResult UpdateSkill(int id, MusicianPatch patch)
    {
        var musician = _musicians.FirstOrDefault(x => x.Id == id);

        if (musician is null)
        {
            return NotFound("yok böyle bir müzisyen");
        }

        musician.Skill = patch.Skill;

        return Ok(musician);

    }


    [HttpDelete("{id}")]

    public IActionResult Delete(int id) 
    {
        var musician = _musicians.FirstOrDefault(x => x.Id == id);

        if (musician is null)
        {
            return NotFound("Yok böyle bir müzisyen");
        }

        _musicians.Remove(musician);

        return Ok("Hokus Pokus Yaptım onu");


    }

    [HttpGet("search")]

    public IActionResult Search([FromQuery] string name)
    {
        var musician = _musicians.Where(x => x.FullName.ToLower().Contains(name.ToLower()));
        if (musician is null)
        {
            return NotFound("Yok böyle bir müzisyen");
        }
        return Ok(musician);
    }
}
