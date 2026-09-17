package cn.com.chinatelecom.account.api.net;

import android.os.Handler;
import android.os.Looper;
import java.util.concurrent.Executor;
import java.util.concurrent.Executors;

/* JADX INFO: loaded from: classes.dex */
public class BaseManager {
    private static Executor mTaskExcutor = Executors.newSingleThreadExecutor();
    public Handler mHandler = new Handler(Looper.getMainLooper());

    public interface ResponseListener<T> {
        void onCallBack(T t);
    }

    public <T> void postData(final T t, final ResponseListener responseListener) {
        this.mHandler.post(new Runnable() { // from class: cn.com.chinatelecom.account.api.net.BaseManager.1
            @Override // java.lang.Runnable
            public void run() {
                ResponseListener responseListener2 = responseListener;
                if (responseListener2 != null) {
                    responseListener2.onCallBack(t);
                }
            }
        });
    }

    public static void execute(Runnable runnable) {
        mTaskExcutor.execute(runnable);
    }
}
