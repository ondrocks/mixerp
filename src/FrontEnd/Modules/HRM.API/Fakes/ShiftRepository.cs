// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Core.Modules.HRM.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.HRM.Fakes
{
    public class ShiftRepository : IShiftRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Shift> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Shift(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Shift(), 1);
        }

        public MixERP.Net.Entities.HRM.Shift Get(int shiftId)
        {
            return new MixERP.Net.Entities.HRM.Shift();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Shift> Get([FromUri] int[] shiftIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Shift(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Shift> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Shift(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Shift> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Shift(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Shift> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Shift(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.HRM.Shift> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.HRM.Shift(), 1);
        }

        public IEnumerable<DisplayField> GetDisplayFields()
        {
            return Enumerable.Repeat(new DisplayField(), 1);
        }

        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            return Enumerable.Repeat(new CustomField(), 1);
        }

        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            return Enumerable.Repeat(new CustomField(), 1);
        }

        public object AddOrEdit(dynamic shift, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic shift, int shiftId)
        {
            if (shiftId > 0)
            {
                return;
            }

            throw new ArgumentException("shiftId is null.");
        }

        public object Add(dynamic shift)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> shifts)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(int shiftId)
        {
            if (shiftId > 0)
            {
                return;
            }

            throw new ArgumentException("shiftId is null.");
        }


    }
}