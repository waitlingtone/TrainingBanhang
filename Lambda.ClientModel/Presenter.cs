using Lambda.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lambda.ClientModel
{
    /// <summary>
    /// Base class for all presenter classes. Keeps track of Model and View classes.
    /// Notice that Model is static and View is set in the constructor.
    /// </summary>
    /// <remarks>
    /// MV Patterns: MVP design pattern.
    /// </remarks>
    /// <typeparam name="T">Type of view.</typeparam>
    public class Presenter<T> where T : IView
    {
        /// <summary>
        /// Gets and sets the model statically.
        /// </summary>
        protected static ModelCore Model { get; set; }

        /// <summary>
        /// Static constructor
        /// </summary>
        static Presenter()
        {
            Model = new ModelCore();
        }

        AutoObjectTransaction _Transaction = new AutoObjectTransaction();
        public AutoObjectTransaction Transaction
        {
            get { return _Transaction; }
        }
        /// <summary>
        /// Constructor. Sets the view.
        /// </summary>
        /// <param name="view">The view.</param>
        public Presenter(T view)
        {
            View = view;
        }

        /// <summary>
        /// Gets and sets the view.
        /// </summary>
        protected T View { get; private set; }
    }
}
