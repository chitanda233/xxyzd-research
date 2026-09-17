package com.sigmob.sdk.mraid2;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.os.Handler;
import android.os.Looper;
import android.view.ViewGroup;
import android.view.WindowInsets;
import android.widget.FrameLayout;
import android.widget.LinearLayout;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.utils.Dips;
import com.czhj.sdk.common.utils.Preconditions;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.windad.WindAdError;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class e {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final FrameLayout f3537a;
    private boolean b = false;
    private m c;
    private c d;
    private LinearLayout e;
    private o f;
    private a g;
    private final List<c> h;
    private final List<BaseAdUnit> i;
    private com.sigmob.sdk.base.common.g j;
    private WindowInsets k;
    private final Handler l;
    private final t m;

    /* JADX INFO: renamed from: com.sigmob.sdk.mraid2.e$2, reason: invalid class name */
    class AnonymousClass2 implements t {
        AnonymousClass2() {
        }

        /* JADX INFO: Access modifiers changed from: private */
        public static /* synthetic */ void a(c cVar, int i, int i2) {
            d mraidBridge;
            if (cVar == null || (mraidBridge = cVar.getMraidBridge()) == null) {
                return;
            }
            mraidBridge.a(i, i2);
        }

        @Override // com.sigmob.sdk.mraid2.t
        public LinearLayout a(c mraid2AdContainer, int orientation) {
            if (e.this.e == null) {
                e.this.e = new LinearLayout(e.this.f());
            }
            if (e.this.f == null) {
                if (orientation == 1) {
                    e.this.f = new l(e.this.f());
                    e.this.e.setOrientation(0);
                } else {
                    e.this.f = new r(e.this.f());
                    e.this.e.setOrientation(1);
                }
                e.this.f.setPageChangedListener(new u() { // from class: com.sigmob.sdk.mraid2.e$2$$ExternalSyntheticLambda0
                    @Override // com.sigmob.sdk.mraid2.u
                    public final void onPageChanged(c cVar, int i, int i2) {
                        e.AnonymousClass2.a(cVar, i, i2);
                    }
                });
                e.this.f.getView().addView(e.this.e, new ViewGroup.LayoutParams(-1, -1));
                e.this.f3537a.addView(e.this.f.getView(), 0, new ViewGroup.LayoutParams(-1, -1));
            }
            if (mraid2AdContainer != null && mraid2AdContainer.getScrollTouchListener() == null) {
                mraid2AdContainer.setScrollTouchListener(new v() { // from class: com.sigmob.sdk.mraid2.e.2.1
                    @Override // com.sigmob.sdk.mraid2.v
                    public void a(c container, JSONObject args) {
                        if (e.this.f == null) {
                            return;
                        }
                        e.this.f.a(container, Dips.asIntPixels(args.optInt("x"), e.this.f()), Dips.asIntPixels(args.optInt("y"), e.this.f()));
                    }

                    @Override // com.sigmob.sdk.mraid2.v
                    public void a(JSONObject args) {
                        if (e.this.f == null) {
                            return;
                        }
                        e.this.f.a(Dips.asIntPixels(args.optInt("x"), e.this.f()), Dips.asIntPixels(args.optInt("y"), e.this.f()));
                    }

                    @Override // com.sigmob.sdk.mraid2.v
                    public void b(JSONObject args) {
                        if (e.this.f == null) {
                            return;
                        }
                        e.this.f.b(Dips.asIntPixels(args.optInt("x"), e.this.f()), Dips.asIntPixels(args.optInt("y"), e.this.f()));
                    }
                });
            }
            return e.this.e;
        }

        @Override // com.sigmob.sdk.mraid2.t
        public c a(c parentWebView, JSONObject args) {
            e eVar = e.this;
            c cVarA = eVar.a(eVar.f(), parentWebView, args);
            e.this.h.add(cVarA);
            return cVarA;
        }

        @Override // com.sigmob.sdk.mraid2.t
        public void a() {
            if (e.this.c == null) {
                return;
            }
            e.this.c.d();
        }

        @Override // com.sigmob.sdk.mraid2.t
        public void a(c container) {
            if (e.this.c != null) {
                e.this.c.b();
            }
            if (e.this.h.isEmpty()) {
                return;
            }
            for (int i = 0; i < e.this.h.size(); i++) {
                ((c) e.this.h.get(i)).b();
            }
        }

        @Override // com.sigmob.sdk.mraid2.t
        public void a(c container, BaseAdUnit adUnit, JSONObject args) {
            if (e.this.c == null) {
                return;
            }
            e.this.c.a(container, adUnit, args);
        }

        @Override // com.sigmob.sdk.mraid2.t
        public void b(c container) {
            if (e.this.c == null) {
                return;
            }
            e.this.c.c();
        }

        @Override // com.sigmob.sdk.mraid2.t
        public void b(c container, JSONObject args) {
            e.this.b = args.optBoolean("flag");
            if (e.this.c == null) {
                return;
            }
            e.this.c.a(e.this.b);
        }
    }

    class a extends BroadcastReceiver {
        private Context b;
        private int c = -1;

        a() {
        }

        public void a() {
            Context context = this.b;
            if (context == null) {
                return;
            }
            context.unregisterReceiver(this);
            this.b = null;
        }

        public void a(Context context) {
            Preconditions.checkNotNull(context);
            Context applicationContext = context.getApplicationContext();
            this.b = applicationContext;
            if (applicationContext == null) {
                return;
            }
            com.sigmob.sdk.base.utils.h.a(applicationContext, this, new IntentFilter("android.intent.action.CONFIGURATION_CHANGED"));
        }

        @Override // android.content.BroadcastReceiver
        public void onReceive(Context context, Intent intent) {
            int screenOrientation;
            if (this.b == null || !"android.intent.action.CONFIGURATION_CHANGED".equals(intent.getAction()) || (screenOrientation = ClientMetadata.getInstance().getScreenOrientation(e.this.f())) == this.c) {
                return;
            }
            this.c = screenOrientation;
            e.this.a(screenOrientation);
        }
    }

    public e(Context context, List<BaseAdUnit> adUnits) {
        ArrayList arrayList = new ArrayList();
        this.h = arrayList;
        this.l = new Handler(Looper.getMainLooper());
        AnonymousClass2 anonymousClass2 = new AnonymousClass2();
        this.m = anonymousClass2;
        Preconditions.checkNotNull(context);
        this.i = adUnits;
        FrameLayout frameLayout = new FrameLayout(context);
        this.f3537a = frameLayout;
        frameLayout.setBackgroundColor(0);
        a aVar = new a();
        this.g = aVar;
        aVar.a(context);
        c cVar = new c(context, adUnits, frameLayout);
        this.d = cVar;
        cVar.setLoadListener(new com.sigmob.sdk.mraid2.a() { // from class: com.sigmob.sdk.mraid2.e.1
            @Override // com.sigmob.sdk.mraid2.a
            public void a(c container) {
                if (e.this.c == null) {
                    return;
                }
                try {
                    e.this.c.a(e.this.d);
                } catch (Throwable th) {
                    th.printStackTrace();
                }
            }

            @Override // com.sigmob.sdk.mraid2.a
            public void a(WindAdError errCode) {
                if (e.this.c == null) {
                    return;
                }
                try {
                    e.this.c.a(errCode);
                } catch (Throwable th) {
                    th.printStackTrace();
                }
            }
        });
        this.d.setNextWebViewListener(anonymousClass2);
        arrayList.clear();
        arrayList.add(this.d);
        frameLayout.addView(this.d, new FrameLayout.LayoutParams(-1, -1));
    }

    /* JADX INFO: Access modifiers changed from: private */
    public c a(Context context, c parentWebView, JSONObject args) {
        c cVar = new c(context, this.i, this.f3537a, parentWebView, args);
        cVar.setAdSize(this.j);
        cVar.setNextWebViewListener(this.m);
        return cVar;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public Context f() {
        FrameLayout frameLayout = this.f3537a;
        if (frameLayout == null) {
            return null;
        }
        return frameLayout.getContext();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void g() {
        SigmobLog.d("onShow end");
        m mVar = this.c;
        if (mVar == null) {
            return;
        }
        mVar.a(this.b);
    }

    public void a() {
        if (com.sigmob.sdk.base.utils.f.a(this.h)) {
            return;
        }
        for (int i = 0; i < this.h.size(); i++) {
            d mraidBridge = this.h.get(i).getMraidBridge();
            if (mraidBridge != null) {
                mraidBridge.a(false);
            }
        }
    }

    void a(int currentRotation) {
        SigmobLog.i("handleOrientationChange " + currentRotation);
        if (com.sigmob.sdk.base.utils.f.a(this.h)) {
            return;
        }
        for (int i = 0; i < this.h.size(); i++) {
            d mraidBridge = this.h.get(i).getMraidBridge();
            if (mraidBridge != null) {
                mraidBridge.e();
                mraidBridge.a(this.j);
            }
        }
    }

    public void a(WindowInsets windowInsets, boolean isLoaded) {
        this.k = windowInsets;
        SigmobLog.d("updateWindowInsets " + windowInsets);
        if (!isLoaded || com.sigmob.sdk.base.utils.f.a(this.h)) {
            return;
        }
        com.sigmob.sdk.base.utils.l lVarA = com.sigmob.sdk.videoplayer.c.a(windowInsets);
        for (int i = 0; i < this.h.size(); i++) {
            d mraidBridge = this.h.get(i).getMraidBridge();
            if (mraidBridge != null) {
                mraidBridge.a(lVarA.a(), lVarA.b(), lVarA.c(), lVarA.d());
            }
        }
    }

    public void a(com.sigmob.sdk.base.common.g adSize) {
        this.j = adSize;
        this.d.setAdSize(adSize);
        this.d.a();
    }

    public void a(BaseAdUnit adUnit) {
        SigmobLog.d("onShow start");
        this.l.postDelayed(new Runnable() { // from class: com.sigmob.sdk.mraid2.e$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.g();
            }
        }, ((long) 5) * 1000);
    }

    public void a(f mraid2ControllerListener) {
        this.d.getMraidBridge().a(mraid2ControllerListener);
    }

    public void a(m mraidListener) {
        this.c = mraidListener;
    }

    public void b() {
        if (com.sigmob.sdk.base.utils.f.a(this.h)) {
            return;
        }
        for (int i = 0; i < this.h.size(); i++) {
            c cVar = this.h.get(i);
            cVar.l();
            d mraidBridge = cVar.getMraidBridge();
            if (mraidBridge != null) {
                mraidBridge.a(true);
            }
        }
    }

    public c c() {
        return this.d;
    }

    public void d() {
        a aVar = this.g;
        if (aVar != null) {
            aVar.a();
            this.g = null;
        }
        try {
            Iterator<c> it = this.h.iterator();
            while (it.hasNext()) {
                it.next().b();
            }
        } catch (Throwable th) {
            th.printStackTrace();
        }
        try {
            this.h.clear();
            this.d = null;
            this.c = null;
        } catch (Throwable unused) {
        }
        this.l.removeCallbacksAndMessages(null);
    }

    public FrameLayout e() {
        return this.f3537a;
    }
}
