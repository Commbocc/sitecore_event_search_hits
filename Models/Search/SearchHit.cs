// add this method to the SearchHit class
public virtual Sitecore.Data.Items.Item ResultItem
{
	get
	{
		return Sitecore.Context.Database.GetItem(this.Id.ToString());
	}
}
