namespace Full_GRASP_And_SOLID
{
    public class RecipeTimerClient : TimerClient
    {
        private Recipe recipe;

        public RecipeTimerClient(Recipe recipe)
        {
            this.recipe = recipe;
        }

        public void TimeOut()
        {
            this.recipe.AlreadyCooked();
        }
    }

}


