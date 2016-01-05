using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateIMiddleWare
{
    public class UseMain
    {
        private LinkedList<IMiddleware> middlewares = new LinkedList<IMiddleware>();

        public TMiddleware Use<TMiddleware>(TMiddleware middleware) where TMiddleware : IMiddleware
        {
            this.Use((IMiddleware)middleware);

            return middleware;
        }

        public TMiddleware Use<TMiddleware>() where TMiddleware : IMiddleware
        {
            var middleware = Activator.CreateInstance<TMiddleware>();
            this.Use(middleware);

            return middleware;
        }

        private void Use(IMiddleware middleware)
        {
            if(null==middleware)
            {
                throw new ArgumentNullException();
            }

            //if (this.middlewares.Count < 1)
            //{
            //    this.middlewares.AddFirst(middleware);
            //}
            //else
            //{
            //    this.middlewares.AddLast(middleware);
            //    //this.middlewares.AddBefore(this.middlewares.Last, middleware);
            //}
            this.middlewares.AddLast(middleware);
            var node = this.middlewares.First;

            while ( null != node )
            {
                if ( null != node.Next )
                {
                    node.Value.Next = node.Next.Value;                
                }
                node = node.Next;
            }
        }

        /// <summary>
        /// 执行会话请求处理
        /// </summary>
        /// <param name="session">会话对象</param>
        public void InvokeRequest()
        {
            try
            {
                var context = new TestContext()
                {
                    AppID="X-A-Z",
                    AccountID="AccountADG"
                };

                var task = this.middlewares.First.Value.Invoke(context);
                //if ( task != null && task.Status == TaskStatus.Created )
                //{
                //    task.Start();
                //}
            }
            catch ( Exception ex )
            {
                Console.WriteLine("执行MiddleWare失败：");
                Console.WriteLine(ex.Message);
                    
            }
        }
    }
}
