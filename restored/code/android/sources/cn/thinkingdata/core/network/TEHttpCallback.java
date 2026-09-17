package cn.thinkingdata.core.network;

import android.os.Handler;
import android.os.Looper;

/* JADX INFO: loaded from: classes.dex */
public abstract class TEHttpCallback {
    static Handler sMainHandler = new Handler(Looper.getMainLooper());
    public boolean callBackOnMainThread = false;

    void onError(final int i, final String str) {
        if (this.callBackOnMainThread) {
            sMainHandler.post(new Runnable() { // from class: cn.thinkingdata.core.network.TEHttpCallback.1
                @Override // java.lang.Runnable
                public void run() {
                    TEHttpCallback.this.onFailure(i, str);
                }
            });
        } else {
            onFailure(i, str);
        }
    }

    public abstract void onFailure(int i, String str);

    void onResponse(final TDNetResponse tDNetResponse) {
        if (this.callBackOnMainThread) {
            sMainHandler.post(new Runnable() { // from class: cn.thinkingdata.core.network.TEHttpCallback.2
                @Override // java.lang.Runnable
                public void run() {
                    TEHttpCallback.this.onSuccess(tDNetResponse);
                }
            });
        } else {
            onSuccess(tDNetResponse);
        }
    }

    public abstract void onSuccess(TDNetResponse tDNetResponse);
}
