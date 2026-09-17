package a.c.a.a.a;

import android.content.ComponentName;
import android.content.ServiceConnection;
import android.os.IBinder;
import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;

/* JADX INFO: loaded from: classes.dex */
public final class a implements ServiceConnection {
    public static final ThreadPoolExecutor c = new ThreadPoolExecutor(0, 3, 60, TimeUnit.SECONDS, new LinkedBlockingQueue(2048), new ThreadPoolExecutor.DiscardPolicy());

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public boolean f20a = false;
    public final LinkedBlockingQueue<IBinder> b = new LinkedBlockingQueue<>(1);

    /* JADX INFO: renamed from: a.c.a.a.a.a$a, reason: collision with other inner class name */
    public class RunnableC0006a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public final /* synthetic */ IBinder f21a;

        public RunnableC0006a(IBinder iBinder) {
            this.f21a = iBinder;
        }

        @Override // java.lang.Runnable
        public final void run() {
            try {
                String str = "onServiceConnected " + System.currentTimeMillis();
                a.this.b.offer(this.f21a);
            } catch (Throwable th) {
                String str2 = "onServiceConnected  " + th.getClass().getSimpleName();
            }
        }
    }

    @Override // android.content.ServiceConnection
    public final void onServiceConnected(ComponentName componentName, IBinder iBinder) {
        c.execute(new RunnableC0006a(iBinder));
    }

    @Override // android.content.ServiceConnection
    public final void onServiceDisconnected(ComponentName componentName) {
        String str = "onServiceDisconnected " + System.currentTimeMillis();
    }
}
