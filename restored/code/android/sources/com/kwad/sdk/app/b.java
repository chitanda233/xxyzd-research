package com.kwad.sdk.app;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.net.Uri;
import android.text.TextUtils;
import com.byazt.quv.AbsServerManager;
import com.kwad.sdk.components.p;
import com.kwad.sdk.core.c.d;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.f;
import com.kwad.sdk.service.a.h;
import com.kwad.sdk.utils.au;
import com.kwad.sdk.utils.n;
import com.kwad.sdk.utils.t;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.concurrent.CopyOnWriteArrayList;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    private static final Map<String, String> aIS = new HashMap();
    private final AtomicBoolean SO;
    private final AtomicBoolean aIT;
    private final AtomicBoolean aIU;
    private final AtomicBoolean aIV;
    private final List<String> aIW;
    private final List<String> aIX;
    private final d aIY;
    private final BroadcastReceiver aIZ;
    private Context mContext;
    private final List<com.kwad.sdk.app.a> mListeners;

    /* synthetic */ b(byte b) {
        this();
    }

    static class a {
        private static final b aJc = new b(0);
    }

    private b() {
        this.aIT = new AtomicBoolean();
        this.aIU = new AtomicBoolean();
        this.SO = new AtomicBoolean();
        this.aIV = new AtomicBoolean();
        this.mListeners = new CopyOnWriteArrayList();
        this.aIW = new CopyOnWriteArrayList();
        this.aIX = new CopyOnWriteArrayList();
        this.aIY = new d() { // from class: com.kwad.sdk.app.b.1
            @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
            public final void onBackToForeground() {
                super.onBackToForeground();
                try {
                    b.this.Ie();
                } catch (Throwable th) {
                    ServiceProvider.reportSdkCaughtException(th);
                }
            }
        };
        this.aIZ = new BroadcastReceiver() { // from class: com.kwad.sdk.app.b.3
            Intent aJb;

            private boolean d(Intent intent) {
                boolean z = TextUtils.equals(this.aJb.getAction(), intent.getAction()) && this.aJb.getFlags() == intent.getFlags() && TextUtils.equals(this.aJb.getDataString(), intent.getDataString());
                this.aJb = intent;
                return z;
            }

            @Override // android.content.BroadcastReceiver
            public final void onReceive(Context context, Intent intent) {
                Uri data;
                if (intent == null) {
                    return;
                }
                try {
                    if (this.aJb == null) {
                        this.aJb = intent;
                    } else if (d(intent)) {
                        return;
                    }
                    c.d("AppInstallManager", "onReceive intent: " + intent.toString());
                    String action = intent.getAction();
                    if (TextUtils.isEmpty(action) || (data = intent.getData()) == null) {
                        return;
                    }
                    String schemeSpecificPart = data.getSchemeSpecificPart();
                    if (TextUtils.isEmpty(schemeSpecificPart)) {
                        return;
                    }
                    b.this.mContext = context;
                    if (TextUtils.equals("android.intent.action.PACKAGE_ADDED", action)) {
                        b.this.D(context, schemeSpecificPart);
                    } else if (TextUtils.equals("android.intent.action.PACKAGE_REMOVED", action)) {
                        b.this.dc(schemeSpecificPart);
                    }
                } catch (Throwable th) {
                    c.printStackTrace(th);
                }
            }
        };
    }

    public static b Ia() {
        return a.aJc;
    }

    public final synchronized void init() {
        try {
            if (this.aIU.get()) {
                return;
            }
            if (((h) ServiceProvider.get(h.class)).Gq()) {
                Id();
                if (((h) ServiceProvider.get(h.class)).Gp()) {
                    com.kwad.sdk.core.c.b.Mh();
                    if (com.kwad.sdk.core.c.b.isAppOnForeground()) {
                        Ig();
                    }
                    Ib();
                } else {
                    Ig();
                }
                this.aIU.set(true);
            }
        } catch (Throwable th) {
            c.printStackTraceOnly(th);
        }
    }

    private void Ib() {
        com.kwad.sdk.core.c.b.Mh();
        com.kwad.sdk.core.c.b.a(new d() { // from class: com.kwad.sdk.app.b.2
            @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
            public final void onBackToBackground() {
                super.onBackToBackground();
                try {
                    b.this.If();
                } catch (Throwable th) {
                    c.printStackTraceOnly(th);
                }
            }

            @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
            public final void onBackToForeground() {
                super.onBackToForeground();
                try {
                    b.this.Ie();
                    b.this.Ig();
                } catch (Throwable th) {
                    c.printStackTraceOnly(th);
                }
            }
        });
    }

    private void Ic() {
        if (this.aIV.get()) {
            return;
        }
        com.kwad.sdk.core.c.b.Mh();
        com.kwad.sdk.core.c.b.a(this.aIY);
        this.aIV.set(true);
    }

    private void Id() {
        if (this.aIV.get()) {
            com.kwad.sdk.core.c.b.Mh();
            com.kwad.sdk.core.c.b.b((com.kwad.sdk.core.c.c) this.aIY);
            this.aIV.set(false);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void Ie() {
        Context contextUm = ServiceProvider.Um();
        bw(contextUm);
        Iterator<AdTemplate> it = ((f) ServiceProvider.get(f.class)).FM().iterator();
        while (it.hasNext()) {
            AdInfo adInfoEM = e.eM(it.next());
            int iBH = com.kwad.sdk.core.response.helper.a.bH(adInfoEM);
            String strAE = com.kwad.sdk.core.response.helper.a.aE(adInfoEM);
            if (iBH != 12) {
                if (au.ax(contextUm, strAE)) {
                    D(contextUm, strAE);
                }
            } else if (!au.ax(contextUm, strAE)) {
                dc(strAE);
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void If() {
        if (this.SO.get()) {
            ServiceProvider.Um().unregisterReceiver(this.aIZ);
            this.SO.set(false);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void Ig() {
        if (this.SO.get()) {
            return;
        }
        IntentFilter intentFilter = new IntentFilter();
        intentFilter.addAction("android.intent.action.PACKAGE_ADDED");
        intentFilter.addAction("android.intent.action.PACKAGE_REMOVED");
        intentFilter.addDataScheme(AbsServerManager.PACKAGE_QUERY_BINDER);
        ServiceProvider.Um().registerReceiver(this.aIZ, intentFilter);
        this.SO.set(true);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void D(Context context, String str) {
        c.d("AppInstallManager", "installApp packageName: " + str);
        G(context, str);
        df(str);
        E(context, str);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void dc(String str) {
        c.d("AppInstallManager", "unInstallApp packageName: " + str);
        dh(str);
        dg(str);
        dd(str);
    }

    private void E(Context context, String str) {
        com.kwad.sdk.core.c.b.Mh();
        if (com.kwad.sdk.core.c.b.isAppOnForeground()) {
            F(context, str);
            return;
        }
        this.aIW.add(str);
        com.kwad.sdk.core.c.b.Mh();
        com.kwad.sdk.core.c.b.a(new d() { // from class: com.kwad.sdk.app.b.4
            @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
            public final void onBackToForeground() {
                if (b.this.aIW.size() > 0) {
                    for (int i = 0; i < b.this.aIW.size(); i++) {
                        b.F(b.this.mContext, (String) b.this.aIW.get(i));
                    }
                    b.this.aIW.clear();
                }
                com.kwad.sdk.core.c.b.Mh();
                com.kwad.sdk.core.c.b.b((com.kwad.sdk.core.c.c) this);
            }
        });
    }

    private void dd(String str) {
        com.kwad.sdk.core.c.b.Mh();
        if (com.kwad.sdk.core.c.b.isAppOnForeground()) {
            de(str);
            return;
        }
        this.aIX.add(str);
        com.kwad.sdk.core.c.b.Mh();
        com.kwad.sdk.core.c.b.a(new d() { // from class: com.kwad.sdk.app.b.5
            @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
            public final void onBackToForeground() {
                if (b.this.aIX.size() > 0) {
                    for (int i = 0; i < b.this.aIX.size(); i++) {
                        b.de((String) b.this.aIX.get(i));
                    }
                    b.this.aIX.clear();
                }
                com.kwad.sdk.core.c.b.Mh();
                com.kwad.sdk.core.c.b.b((com.kwad.sdk.core.c.c) this);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void F(Context context, String str) {
        try {
            p pVar = (p) com.kwad.sdk.components.d.f(p.class);
            if (pVar == null || !t.UT()) {
                return;
            }
            ((com.kwad.sdk.service.a.b) ServiceProvider.get(com.kwad.sdk.service.a.b.class)).e(pVar.e(context, str), 1);
        } catch (Throwable th) {
            c.printStackTrace(th);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void de(String str) {
        try {
            p pVar = (p) com.kwad.sdk.components.d.f(p.class);
            if (pVar == null || !t.UT()) {
                return;
            }
            ((com.kwad.sdk.service.a.b) ServiceProvider.get(com.kwad.sdk.service.a.b.class)).e(pVar.B(str), 2);
        } catch (Throwable th) {
            c.printStackTrace(th);
        }
    }

    public final void a(com.kwad.sdk.app.a aVar) {
        if (aVar == null) {
            return;
        }
        Ic();
        this.mListeners.add(aVar);
    }

    public final void b(com.kwad.sdk.app.a aVar) {
        if (aVar == null) {
            return;
        }
        Ic();
        this.mListeners.remove(aVar);
    }

    private void df(String str) {
        Iterator<com.kwad.sdk.app.a> it = this.mListeners.iterator();
        while (it.hasNext()) {
            try {
                it.next().T(str);
            } catch (Throwable th) {
                c.printStackTrace(th);
            }
        }
    }

    private void dg(String str) {
        Iterator<com.kwad.sdk.app.a> it = this.mListeners.iterator();
        while (it.hasNext()) {
            try {
                it.next().U(str);
            } catch (Throwable th) {
                c.printStackTrace(th);
            }
        }
    }

    public final String getVersion(Context context, String str) {
        if (TextUtils.isEmpty(str)) {
            return "";
        }
        bv(context);
        return aIS.get(str);
    }

    private synchronized void bv(Context context) {
        if (this.aIT.get()) {
            return;
        }
        G(context, "com.smile.gifmaker");
        G(context, "com.kuaishou.nebula");
        G(context, "com.tencent.mm");
        this.aIT.set(true);
    }

    private void bw(Context context) {
        if (this.aIT.get()) {
            for (String str : aIS.keySet()) {
                String str2 = aIS.get(str);
                String strS = n.S(context, str);
                if (!TextUtils.isEmpty(strS) && !TextUtils.equals(str2, strS)) {
                    D(context, str);
                } else if (TextUtils.isEmpty(strS) && !TextUtils.isEmpty(str2)) {
                    dc(str);
                }
            }
        }
    }

    private static void G(Context context, String str) {
        str.hashCode();
        switch (str) {
            case "com.tencent.mm":
                aIS.put("com.tencent.mm", n.S(context, "com.tencent.mm"));
                break;
            case "com.kuaishou.nebula":
                aIS.put("com.kuaishou.nebula", n.S(context, "com.kuaishou.nebula"));
                break;
            case "com.smile.gifmaker":
                aIS.put("com.smile.gifmaker", n.S(context, "com.smile.gifmaker"));
                break;
        }
    }

    private static void dh(String str) {
        str.hashCode();
        switch (str) {
            case "com.tencent.mm":
                aIS.put("com.tencent.mm", "");
                break;
            case "com.kuaishou.nebula":
                aIS.put("com.kuaishou.nebula", "");
                break;
            case "com.smile.gifmaker":
                aIS.put("com.smile.gifmaker", "");
                break;
        }
    }
}
