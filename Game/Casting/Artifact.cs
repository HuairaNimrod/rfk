namespace Unit04.Game.Casting
{
    // TODO: Implement the Artifact class here

    /// <summary>
    /// <para>An item of cultural or historical interest.</para>
    /// <para>
    /// The responsibility of an Artifact is to provide a message about itself.
    /// </para>
    /// </summary>    
    class Artifact : Actor
    {
        private string _message = null;
        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
        public Artifact()
        {

        }

        /// <summary>
        /// Gets the artifact's message.
        /// </summary>
        /// <returns>The message as a string.</returns>
        public string GetMessage(){
            return _message;
        }


        /// <summary>
        /// Sets the artifact's message to the given value.
        /// </summary>
        /// <param name="message">The given message.</param>
        public void SetMessage(string message){
            _message = message;
        }
       












    }

 

}