package com.kwad.sdk.core.network.idc;

import android.content.Context;
import android.net.Uri;
import android.os.SystemClock;
import android.text.TextUtils;
import com.byazt.bv.BaseConstants;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.core.network.d;
import com.kwad.sdk.export.proxy.AdHttpProxy;
import com.kwad.sdk.h;
import com.kwad.sdk.utils.aq;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.i;
import java.net.URLDecoder;
import java.util.Collections;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.Random;
import java.util.concurrent.ConcurrentHashMap;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static final int aUl;
    private final Map<String, String> aUg;
    private final com.kwad.sdk.core.network.idc.a.b aUh;
    private final Random aUi;
    private final Map<String, AtomicBoolean> aUj;
    private final Map<String, com.kwad.sdk.core.network.idc.a.a> aUk;
    private volatile int aUm;
    private volatile boolean aUn;
    private Context mContext;

    /* synthetic */ a(byte b) {
        this();
    }

    static /* synthetic */ boolean a(a aVar, boolean z) {
        aVar.aUn = false;
        return false;
    }

    /* JADX INFO: renamed from: com.kwad.sdk.core.network.idc.a$a, reason: collision with other inner class name */
    static final class C0516a {
        private static final a aUq = new a(0);
    }

    private a() {
        this.aUg = new ConcurrentHashMap(8);
        this.aUh = new com.kwad.sdk.core.network.idc.a.b();
        this.aUi = new Random(System.currentTimeMillis());
        HashMap map = new HashMap();
        this.aUj = map;
        this.aUk = new ConcurrentHashMap(4);
        this.aUm = 0;
        this.aUn = false;
        map.put("api", new AtomicBoolean(false));
        map.put("ulog", new AtomicBoolean(false));
        map.put("zt", new AtomicBoolean(false));
        map.put("cdn", new AtomicBoolean(false));
    }

    public static a My() {
        return C0516a.aUq;
    }

    static {
        aUl = com.kwad.framework.a.a.oV.booleanValue() ? 0 : BaseConstants.Time.MINUTE;
    }

    public final void init(final Context context) {
        this.mContext = context.getApplicationContext();
        this.aUn = true;
        i.execute(new bi() { // from class: com.kwad.sdk.core.network.idc.a.1
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                a.this.aUg.putAll(b.bV(context));
                a.this.Mz();
                if (!a.this.aUh.isEmpty()) {
                    Iterator<String> it = a.this.aUh.MF().iterator();
                    while (it.hasNext()) {
                        a.this.eM(it.next());
                    }
                }
                c.d("IdcManager", "idc prepare done.");
                a.a(a.this, false);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void Mz() {
        com.kwad.sdk.core.network.idc.a.b bVarBU = b.bU(this.mContext);
        if (bVarBU.isEmpty()) {
            bVarBU = b.bT(this.mContext);
        }
        this.aUh.a(bVarBU);
    }

    public final void a(com.kwad.sdk.core.network.idc.a.b bVar, int i) {
        this.aUm = i * 1000;
        c.d("IdcManager", "updateIdcData,rollback interval = " + i);
        if (i == 0) {
            this.aUk.clear();
        }
        this.aUh.a(bVar);
        i.execute(new bi() { // from class: com.kwad.sdk.core.network.idc.a.2
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                b.a(a.this.mContext, a.this.aUh);
            }
        });
    }

    private void X(String str, String str2) {
        String host;
        StringBuilder sb;
        List<String> listEP = this.aUh.eP(str2);
        if (listEP.isEmpty() || (host = Uri.parse(str).getHost()) == null || host.isEmpty()) {
            return;
        }
        c.d("IdcManager", ">>> switchHost start, try get lock, type = " + str2 + ", old host = " + host);
        AtomicBoolean atomicBoolean = this.aUj.get(str2);
        if (atomicBoolean.compareAndSet(false, true)) {
            try {
                String strEN = eN(str2);
                if ((TextUtils.isEmpty(strEN) || host.equals(strEN)) ? false : true) {
                    atomicBoolean.set(false);
                    sb = new StringBuilder("<<< switchHost end, type = ");
                } else {
                    int size = listEP.size();
                    int iIndexOf = listEP.indexOf(host);
                    boolean z = iIndexOf >= 0;
                    if (z) {
                        size--;
                    }
                    if (size <= 0) {
                        atomicBoolean.set(false);
                        sb = new StringBuilder("<<< switchHost end, type = ");
                    } else {
                        int iNextInt = this.aUi.nextInt(size) + 1;
                        if (z) {
                            iNextInt += iIndexOf;
                        }
                        int size2 = iNextInt % listEP.size();
                        String str3 = listEP.get(size2);
                        c.d("IdcManager", "switchHost success, type = " + str2 + ", old host = " + host + ",new host = " + str3 + ",hostList = " + listEP + ", key = " + size2);
                        Z(str2, str3);
                        if (q(str2, size2)) {
                            eK(str2);
                        }
                        atomicBoolean.set(false);
                        sb = new StringBuilder("<<< switchHost end, type = ");
                    }
                }
                StringBuilder sbAppend = sb.append(str2);
            } finally {
                atomicBoolean.set(false);
                c.d("IdcManager", "<<< switchHost end, type = " + str2 + ", old host = " + host);
            }
        }
    }

    private boolean q(String str, int i) {
        return "api".equals(str) && i > 0 && !this.aUk.containsKey(str) && this.aUm > 0;
    }

    private void eK(String str) {
        long jElapsedRealtime = SystemClock.elapsedRealtime();
        c.d("IdcManager", "save switched host, type = " + str);
        this.aUk.put(str, new com.kwad.sdk.core.network.idc.a.a(jElapsedRealtime, false));
    }

    public final boolean MA() {
        return !this.aUk.isEmpty();
    }

    public final void eL(String str) {
        int i = this.aUm;
        if (this.aUn || i <= 0) {
            c.d("IdcManager", "performHostRollback is invalid, by in prepare = " + this.aUn + ",rollbackInterval = " + i);
            return;
        }
        com.kwad.sdk.core.network.idc.a.a aVar = this.aUk.get(str);
        if (aVar != null) {
            long jElapsedRealtime = SystemClock.elapsedRealtime() - aVar.MD();
            boolean z = jElapsedRealtime > ((long) Math.max(i, aUl));
            c.d("IdcManager", "handleHostRollback: isAvailable = " + z + ",interval = " + jElapsedRealtime + ",rollbackInterval = " + i + ",hostType = hostType");
            if (z) {
                AtomicBoolean atomicBoolean = this.aUj.get(str);
                try {
                    if (atomicBoolean.compareAndSet(false, true)) {
                        boolean zMC = aVar.MC();
                        c.d("IdcManager", "handleHostRollback: isInRollback = " + zMC);
                        if (!zMC) {
                            aVar.bF(true);
                            if (eM(str)) {
                                this.aUk.remove(str);
                                c.d("IdcManager", "handleHostRollback success,remove switched host, type = " + str);
                            } else {
                                c.d("IdcManager", "rollbackToMainHost failed, reset attempt time.");
                                eK(str);
                            }
                        }
                    }
                } catch (Exception e) {
                    c.e("IdcManager", "handleHostRollback failed by " + e.getMessage());
                } finally {
                    atomicBoolean.set(false);
                    c.d("IdcManager", "handleHostRollback end, release lock.host = " + str);
                }
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public boolean eM(String str) {
        boolean zHS;
        String strEN = eN(str);
        List<String> listEP = this.aUh.eP(str);
        if (listEP.isEmpty()) {
            return false;
        }
        String str2 = listEP.get(0);
        if (TextUtils.equals(str2, strEN)) {
            return true;
        }
        if ("api".equals(str)) {
            zHS = c(com.kwad.framework.a.a.oV.booleanValue() ? "beta2-ad-open-api.test.gifshow.com" : str2, this.mContext);
        } else {
            zHS = aq.hS(str2);
        }
        c.d("IdcManager", "perform ping action for " + str + ",mainHost = " + str2 + ",isSuccess = " + zHS);
        if (zHS) {
            Z(str, str2);
        }
        return zHS;
    }

    public final String Y(String str, String str2) {
        String str3 = this.aUg.get(str);
        return TextUtils.isEmpty(str3) ? str2 : str3;
    }

    private String eN(String str) {
        return this.aUg.get(str);
    }

    private void Z(String str, String str2) {
        c.d("IdcManager", "updateCurrentIdc: hostType = " + str + ",new host = " + str2);
        this.aUg.put(str, str2);
        i.execute(new bi() { // from class: com.kwad.sdk.core.network.idc.a.3
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                b.a(a.this.mContext, (Map<String, String>) a.this.aUg);
            }
        });
    }

    public final void a(String str, int i, Throwable th) {
        a(str, "ulog", new DomainException(i, th));
    }

    public final void h(String str, Throwable th) {
        a(str, "cdn", new DomainException(th));
    }

    public final void a(String str, String str2, DomainException domainException) {
        if (str != null && a(domainException)) {
            X(str, str2);
        }
    }

    private static boolean a(DomainException domainException) {
        if (domainException.getHttpCode() >= 500) {
            return true;
        }
        return domainException.isConnectException();
    }

    public final String eO(String str) {
        return aa(str, "cdn");
    }

    public final String aa(String str, String str2) {
        if (TextUtils.isEmpty(str)) {
            return "";
        }
        String strEN = eN(str2);
        if (strEN == null || strEN.isEmpty()) {
            return str;
        }
        Uri uri = Uri.parse(str);
        if (TextUtils.isEmpty(uri.getPath()) || strEN.equals(uri.getHost())) {
            return str;
        }
        Uri.Builder builder = new Uri.Builder();
        builder.authority(strEN);
        if (TextUtils.isEmpty(uri.getScheme())) {
            builder.scheme("https");
        } else {
            builder.scheme(uri.getScheme());
        }
        builder.path(uri.getPath());
        if (!TextUtils.isEmpty(uri.getQuery())) {
            builder.query(uri.getQuery());
        }
        return URLDecoder.decode(builder.build().toString());
    }

    private static boolean c(final String str, Context context) {
        boolean zIsNetworkConnected = aq.isNetworkConnected(context);
        c.d("IdcManager", "connect host = " + str + ",isNetworkConnected = " + zIsNetworkConnected);
        if (zIsNetworkConnected && str != null) {
            AdHttpProxy adHttpProxyES = h.ES();
            d dVar = new d() { // from class: com.kwad.sdk.core.network.idc.a.4
                @Override // com.kwad.sdk.core.network.d, com.kwad.sdk.core.network.b
                public final void buildBaseBody() {
                }

                @Override // com.kwad.sdk.core.network.d, com.kwad.sdk.core.network.b
                public final void buildBaseHeader() {
                }

                @Override // com.kwad.sdk.core.network.b, com.kwad.sdk.core.network.f
                public final String getUrl() {
                    return com.kwad.sdk.i.cL("https://" + str);
                }
            };
            com.kwad.sdk.core.network.c cVarDoGet = adHttpProxyES.doGet(dVar.getUrl(), Collections.emptyMap());
            c.d("IdcManager", "perform connect host:" + dVar.getUrl());
            if (cVarDoGet != null) {
                c.d("IdcManager", "connect host response, rawCode = " + cVarDoGet.aSW + ",body = " + cVarDoGet.aSY);
                if (cVarDoGet.aSW == 200) {
                    return true;
                }
            }
        }
        return false;
    }
}
