using Microsoft.AspNetCore.Mvc;
using Microsoft.TeamFoundation.SourceControl.WebApi;
using static webapi.Engines.CardEngine;

namespace webapi.Managers
{
    [ApiController]
    [Route("[manager]")]
    public class BoardManager : ControllerBase
    {
        /*
         * Commenting what I think we need to do on this file
         * 1. Add a way of communicating with react front end
         * 2. Creating a Deck of cards to give to the front end to display
        */

        [HttpGet("{itemType:int}")] // this code runs when then fetch method is called in js
        public ItemModel[] Get(int itemType)
        {
            Deck deck = new Deck();

            ItemModel cards = deck.cards.Where(card => card.Suit == itemType)

            return cards;
        }
    }
}
