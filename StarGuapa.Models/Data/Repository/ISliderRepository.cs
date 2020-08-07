using StarGuapa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarGuapa.DataAccess.Data.Repository
{
    public interface ISliderRepository : IRepository<Slider>
    {
        void Update(Slider slider);
    }
}
