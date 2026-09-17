package com.kwad.sdk.core.webview.b;

import android.content.Context;
import android.text.TextUtils;
import android.util.Log;
import android.webkit.WebResourceResponse;
import com.kwad.sdk.core.NetworkMonitor;
import com.kwad.sdk.core.config.c;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.core.response.model.SdkConfigData;
import com.kwad.sdk.crash.utils.h;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ac;
import com.kwad.sdk.utils.aq;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.br;
import com.kwad.sdk.utils.i;
import com.kwad.sdk.utils.y;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;
import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class a {
    private static volatile a bcC;
    private long alM;
    private Context mContext;
    private volatile boolean mHasInit = false;
    private final List<com.kwad.sdk.h.a.b> bcD = new CopyOnWriteArrayList();
    private final List<String> bcE = new CopyOnWriteArrayList();
    private final List<String> bcF = new CopyOnWriteArrayList();
    private final NetworkMonitor.a bcG = new NetworkMonitor.a() { // from class: com.kwad.sdk.core.webview.b.a.2
        @Override // com.kwad.sdk.core.NetworkMonitor.a
        public final void a(NetworkMonitor.NetworkState networkState) {
            if (networkState == NetworkMonitor.NetworkState.NETWORK_WIFI || networkState == NetworkMonitor.NetworkState.NETWORK_MOBILE) {
                a.this.PR();
            }
        }
    };

    private a() {
    }

    public static a PQ() {
        if (bcC == null) {
            synchronized (a.class) {
                if (bcC == null) {
                    bcC = new a();
                }
            }
        }
        return bcC;
    }

    public final synchronized void init(final Context context) {
        if (!this.mHasInit && context != null) {
            this.mContext = ServiceProvider.Um();
            this.mHasInit = true;
            i.execute(new bi() { // from class: com.kwad.sdk.core.webview.b.a.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    try {
                        if (e.b(c.aOH)) {
                            a.this.alM = System.currentTimeMillis();
                            a.this.cp(context);
                            a.this.PR();
                            NetworkMonitor.getInstance().a(a.this.mContext, a.this.bcG);
                        }
                    } catch (Throwable th) {
                        ((com.kwad.sdk.service.a.e) ServiceProvider.get(com.kwad.sdk.service.a.e.class)).gatherException(th);
                    }
                }
            });
        }
    }

    public final long wZ() {
        return this.alM;
    }

    public final void PR() {
        if (e.Km()) {
            i.execute(new bi() { // from class: com.kwad.sdk.core.webview.b.a.3
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    try {
                        List<com.kwad.sdk.h.a.b> listPS = a.this.PS();
                        if (listPS != null && !listPS.isEmpty()) {
                            a.this.M(listPS);
                            for (com.kwad.sdk.h.a.b bVar : listPS) {
                                if (bVar != null && bVar.packageType == 1 && (bVar.loadType == 1 || (bVar.loadType == 2 && aq.isWifiConnected(a.this.mContext)))) {
                                    a.this.a(bVar);
                                }
                            }
                        }
                    } catch (Throwable th) {
                        ((com.kwad.sdk.service.a.e) ServiceProvider.get(com.kwad.sdk.service.a.e.class)).gatherException(th);
                    }
                }
            });
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(com.kwad.sdk.h.a.b bVar) {
        if (this.bcF.contains(bVar.bgG) || TextUtils.isEmpty(bVar.packageUrl)) {
            return;
        }
        com.kwad.sdk.core.webview.b.b.a.a(bVar, new com.kwad.sdk.core.webview.b.b.a.InterfaceC0520a() { // from class: com.kwad.sdk.core.webview.b.a.4
            @Override // com.kwad.sdk.core.webview.b.b.a.InterfaceC0520a
            public final void c(com.kwad.sdk.h.a.b bVar2) {
                a.this.bcF.add(bVar2.bgG);
                com.kwad.sdk.core.d.c.d("HybridPackageManager", "download onStart: " + bVar2.toString());
            }

            @Override // com.kwad.sdk.core.webview.b.b.a.InterfaceC0520a
            public final void d(com.kwad.sdk.h.a.b bVar2) {
                com.kwad.sdk.core.d.c.d("HybridPackageManager", "download success: " + bVar2.toString());
                if (com.kwad.sdk.core.webview.b.b.b.a(a.this.mContext, bVar2)) {
                    com.kwad.sdk.core.d.c.d("HybridPackageManager", "install success: " + bVar2.toString());
                    a.this.bcD.add(bVar2);
                    a aVar = a.this;
                    aVar.co(aVar.mContext);
                    com.kwad.sdk.core.webview.b.c.b.a(bVar2, 4);
                }
                a.this.bcF.remove(bVar2.bgG);
            }

            @Override // com.kwad.sdk.core.webview.b.b.a.InterfaceC0520a
            public final void e(com.kwad.sdk.h.a.b bVar2) {
                com.kwad.sdk.core.d.c.d("HybridPackageManager", "download failure: " + bVar2.toString());
                a.this.bcF.remove(bVar2.bgG);
            }
        });
    }

    public final WebResourceResponse ac(String str, String str2) {
        if (!this.mHasInit) {
            return null;
        }
        String strFM = com.kwad.sdk.core.webview.b.c.a.fM(str);
        if (!TextUtils.isEmpty(strFM)) {
            com.kwad.sdk.core.webview.b.c.b.d(str2, strFM, str);
            WebResourceResponse webResourceResponseAd = ad(strFM, str);
            com.kwad.sdk.core.webview.b.c.b.e(str2, strFM, str);
            return webResourceResponseAd;
        }
        return fH(str);
    }

    private WebResourceResponse ad(String str, String str2) {
        long jCurrentTimeMillis = System.currentTimeMillis();
        try {
            com.kwad.sdk.core.webview.b.c.b.a aVar = new com.kwad.sdk.core.webview.b.c.b.a();
            this.bcE.add(str);
            WebResourceResponse webResourceResponseA = a(str, str2, aVar, false);
            long jCurrentTimeMillis2 = System.currentTimeMillis() - jCurrentTimeMillis;
            if (webResourceResponseA != null) {
                com.kwad.sdk.core.d.c.d("HybridPackageManager", "load success time:" + jCurrentTimeMillis2 + "--url:" + str2);
                com.kwad.sdk.core.webview.b.c.b.a(str2, str, 1, "", jCurrentTimeMillis2);
            } else {
                com.kwad.sdk.core.d.c.d("HybridPackageManager", "load fail errorMsg:" + aVar.msg + "-url:" + str2);
                com.kwad.sdk.core.webview.b.c.b.a(str2, str, 2, aVar.msg, jCurrentTimeMillis2);
            }
            return webResourceResponseA;
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            com.kwad.sdk.core.webview.b.c.b.a(str2, str, 2, "HybridWebViewClient中 Exception " + Log.getStackTraceString(th), System.currentTimeMillis() - jCurrentTimeMillis);
            return null;
        }
    }

    private WebResourceResponse fH(String str) {
        try {
            com.kwad.sdk.core.webview.b.c.b.a aVar = new com.kwad.sdk.core.webview.b.c.b.a();
            synchronized (this.bcD) {
                Iterator<String> it = this.bcE.iterator();
                while (it.hasNext()) {
                    WebResourceResponse webResourceResponseA = a(it.next(), str, aVar, true);
                    if (webResourceResponseA != null) {
                        return webResourceResponseA;
                    }
                }
                return null;
            }
        } catch (Throwable th) {
            th.printStackTrace();
            return null;
        }
    }

    private WebResourceResponse a(String str, String str2, com.kwad.sdk.core.webview.b.c.b.a aVar, boolean z) {
        com.kwad.sdk.h.a.b bVarFJ = fJ(str);
        if (bVarFJ == null) {
            com.kwad.sdk.h.a.b bVarFI = fI(str);
            if (bVarFI == null) {
                aVar.msg = "配置文件没有下发该zip资源";
                return null;
            }
            aVar.msg = "资源未下载:" + bVarFI.loadType;
            b(bVarFI);
            return null;
        }
        return b.a(this.mContext, str2, bVarFJ, aVar, z);
    }

    private com.kwad.sdk.h.a.b fI(String str) {
        List<com.kwad.sdk.h.a.b> listPS = PS();
        if (listPS != null && !listPS.isEmpty()) {
            for (com.kwad.sdk.h.a.b bVar : listPS) {
                if (br.isEquals(str, bVar.bgG)) {
                    return bVar;
                }
            }
        }
        return null;
    }

    private com.kwad.sdk.h.a.b fJ(String str) {
        synchronized (this.bcD) {
            if (!TextUtils.isEmpty(str) && this.bcD.size() > 0) {
                for (com.kwad.sdk.h.a.b bVar : this.bcD) {
                    if (TextUtils.equals(str, bVar.bgG)) {
                        return bVar;
                    }
                }
                return null;
            }
            return null;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public List<com.kwad.sdk.h.a.b> PS() {
        List<com.kwad.sdk.h.a.a> list;
        SdkConfigData sdkConfigDataKd = e.Kd();
        if (sdkConfigDataKd == null || (list = sdkConfigDataKd.h5PreloadConfigs) == null) {
            return null;
        }
        ArrayList arrayList = new ArrayList();
        for (com.kwad.sdk.h.a.a aVar : list) {
            if (aVar != null && aVar.bgF != null) {
                for (com.kwad.sdk.h.a.b bVar : aVar.bgF) {
                    a(bVar, aVar);
                    if (bVar.isValid()) {
                        arrayList.add(bVar);
                    }
                }
            }
        }
        return arrayList;
    }

    private void a(com.kwad.sdk.h.a.b bVar, com.kwad.sdk.h.a.a aVar) {
        bVar.bgG = aVar.sceneId;
        if (TextUtils.isEmpty(bVar.packageUrl)) {
            return;
        }
        String strFN = com.kwad.sdk.core.webview.b.c.a.fN(bVar.packageUrl);
        if (TextUtils.isEmpty(strFN)) {
            return;
        }
        bVar.bgH = strFN;
        bVar.bgI = com.kwad.sdk.core.webview.b.c.a.L(this.mContext, bVar.bgH);
    }

    private void b(final com.kwad.sdk.h.a.b bVar) {
        i.execute(new bi() { // from class: com.kwad.sdk.core.webview.b.a.5
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                com.kwad.sdk.h.a.b bVar2 = bVar;
                if (bVar2 != null) {
                    a.this.a(bVar2);
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void M(List<com.kwad.sdk.h.a.b> list) {
        synchronized (this.bcD) {
            cp(this.mContext);
            for (com.kwad.sdk.h.a.b bVar : this.bcD) {
                if (list.contains(bVar)) {
                    if (y.hG(com.kwad.sdk.core.webview.b.c.a.N(this.mContext, bVar.bgH))) {
                        list.remove(bVar);
                    }
                } else {
                    y.ad(new File(bVar.bgI));
                    this.bcD.remove(bVar);
                }
            }
            co(this.mContext);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void co(Context context) {
        synchronized (this.bcD) {
            FileOutputStream fileOutputStream = null;
            try {
                try {
                    try {
                        File fileCs = com.kwad.sdk.core.webview.b.c.a.cs(context);
                        String string = ac.Y(this.bcD).toString();
                        FileOutputStream fileOutputStream2 = new FileOutputStream(fileCs);
                        try {
                            fileOutputStream2.write(string.getBytes());
                            com.kwad.sdk.crash.utils.b.closeQuietly(fileOutputStream2);
                        } catch (Exception unused) {
                            fileOutputStream = fileOutputStream2;
                            com.kwad.sdk.core.d.c.e("updatePackageIndexFile", "read packageIndex file error");
                            com.kwad.sdk.crash.utils.b.closeQuietly(fileOutputStream);
                        } catch (Throwable th) {
                            th = th;
                            fileOutputStream = fileOutputStream2;
                            com.kwad.sdk.crash.utils.b.closeQuietly(fileOutputStream);
                            throw th;
                        }
                    } catch (Exception unused2) {
                    }
                    this.bcE.clear();
                    for (com.kwad.sdk.h.a.b bVar : this.bcD) {
                        if (bVar.bgK) {
                            this.bcE.add(bVar.bgG);
                        }
                    }
                } catch (Throwable th2) {
                    th = th2;
                }
            } catch (Throwable th3) {
                throw th3;
            }
        }
    }

    @Deprecated
    private static List<com.kwad.sdk.h.a.b> a(String str, com.kwad.sdk.core.c<com.kwad.sdk.h.a.b> cVar) {
        ArrayList arrayList = new ArrayList();
        if (TextUtils.isEmpty(str)) {
            return arrayList;
        }
        try {
            JSONArray jSONArray = new JSONArray(str);
            for (int i = 0; i < jSONArray.length(); i++) {
                JSONObject jSONObject = jSONArray.getJSONObject(i);
                com.kwad.sdk.h.a.b bVar = (com.kwad.sdk.h.a.b) cVar.IM();
                bVar.parseJson(jSONObject);
                arrayList.add(bVar);
            }
        } catch (Throwable unused) {
        }
        return arrayList;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void cp(Context context) {
        FileInputStream fileInputStream;
        List<com.kwad.sdk.h.a.b> listA;
        synchronized (this.bcD) {
            FileInputStream fileInputStream2 = null;
            FileInputStream fileInputStream3 = null;
            List<com.kwad.sdk.h.a.b> list = null;
            try {
                try {
                    File fileCs = com.kwad.sdk.core.webview.b.c.a.cs(context);
                    if (y.Q(fileCs)) {
                        fileInputStream = new FileInputStream(fileCs);
                        try {
                            try {
                                listA = a(h.b(new InputStreamReader(fileInputStream)), new com.kwad.sdk.core.c<com.kwad.sdk.h.a.b>() { // from class: com.kwad.sdk.core.webview.b.a.6
                                    @Override // com.kwad.sdk.core.c
                                    public final /* synthetic */ com.kwad.sdk.core.b IM() {
                                        return PT();
                                    }

                                    private static com.kwad.sdk.h.a.b PT() {
                                        return new com.kwad.sdk.h.a.b();
                                    }
                                });
                                fileInputStream3 = fileInputStream;
                            } catch (Exception e) {
                                e = e;
                                e.printStackTrace();
                                com.kwad.sdk.crash.utils.b.closeQuietly(fileInputStream);
                            }
                        } catch (Throwable th) {
                            th = th;
                            fileInputStream2 = fileInputStream;
                            com.kwad.sdk.crash.utils.b.closeQuietly(fileInputStream2);
                            throw th;
                        }
                    } else {
                        listA = null;
                    }
                    com.kwad.sdk.crash.utils.b.closeQuietly(fileInputStream3);
                    list = listA;
                } catch (Throwable th2) {
                    throw th2;
                }
            } catch (Exception e2) {
                e = e2;
                fileInputStream = null;
            } catch (Throwable th3) {
                th = th3;
                com.kwad.sdk.crash.utils.b.closeQuietly(fileInputStream2);
                throw th;
            }
            if (list != null) {
                this.bcD.clear();
                this.bcD.addAll(list);
            }
            this.bcE.clear();
            for (com.kwad.sdk.h.a.b bVar : this.bcD) {
                if (!y.hG(com.kwad.sdk.core.webview.b.c.a.N(this.mContext, bVar.bgH))) {
                    this.bcD.remove(bVar);
                }
                if (bVar.bgK) {
                    this.bcE.add(bVar.bgG);
                }
            }
        }
    }
}
