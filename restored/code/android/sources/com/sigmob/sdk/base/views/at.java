package com.sigmob.sdk.base.views;

import android.app.Activity;
import android.content.Context;
import android.content.MutableContextWrapper;
import androidx.lifecycle.LifecycleKt$$ExternalSyntheticBackportWithForwarding0;
import com.czhj.sdk.logger.SigmobLog;
import java.util.Queue;
import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.atomic.AtomicReference;

/* JADX INFO: loaded from: classes3.dex */
public class at {
    private static at c = null;
    private static final AtomicReference<at> d = new AtomicReference<>();
    private static final int e = 2;
    private final Object b = new Object();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Queue<g> f3306a = new LinkedBlockingQueue(2);

    private at() {
    }

    public static at a() {
        AtomicReference<at> atomicReference;
        do {
            at atVar = c;
            if (atVar != null) {
                return atVar;
            }
            atomicReference = d;
        } while (!LifecycleKt$$ExternalSyntheticBackportWithForwarding0.m(atomicReference, null, new at()));
        at atVar2 = atomicReference.get();
        c = atVar2;
        return atVar2;
    }

    private g b(Context activity) {
        g gVar;
        Queue<g> queue = this.f3306a;
        g gVarPoll = queue != null ? queue.poll() : null;
        SigmobLog.i("acquireWebViewInternal webview:" + gVarPoll);
        if (gVarPoll != null) {
            ((MutableContextWrapper) gVarPoll.getContext()).setBaseContext(activity);
            return gVarPoll;
        }
        synchronized (this.b) {
            gVar = new g(new MutableContextWrapper(activity));
        }
        return gVar;
    }

    private void b(g webView) {
        try {
            if (webView.getContext() instanceof MutableContextWrapper) {
                MutableContextWrapper mutableContextWrapper = (MutableContextWrapper) webView.getContext();
                mutableContextWrapper.setBaseContext(mutableContextWrapper.getApplicationContext());
                SigmobLog.i("enqueue  webview:" + webView);
                if (this.f3306a != null) {
                    webView.b();
                    this.f3306a.offer(webView);
                } else {
                    webView.destroy();
                }
            }
            if (webView.getContext() instanceof Activity) {
                SigmobLog.i("Abandon this webview  ， It will cause leak if enqueue !");
            }
        } catch (Exception e2) {
            e2.printStackTrace();
        }
    }

    public g a(Context context) {
        return b(context);
    }

    public void a(g webView) {
        b(webView);
    }
}
