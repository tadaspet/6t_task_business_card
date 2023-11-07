namespace II._18.Advanced._12.AsyncAndAwait
{
    public class Kitchen
    {
        public async Task<IEnumerable<Meal>> PrepareImitation(IEnumerable<Meal> orders)
        {
            var patiekalai = new List<Meal>();
            foreach (var o in orders) 
            {
                var patiekalas = await o.Prepare();
                patiekalai.Add(patiekalas);
            }
            return await Task.WhenAll(orders.Select(o => o.Prepare()));
        }


        public async Task<IEnumerable<Meal>> Prepare(IEnumerable<Meal> orders)
        {
            return await Task.WhenAll(orders.Select(o => o.Prepare()));
        }
    }
}