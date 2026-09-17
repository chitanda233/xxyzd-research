package com.kwad.components.core.d;

import android.content.Context;
import android.os.Build;
import android.os.Environment;
import android.text.TextUtils;
import cn.com.chinatelecom.account.api.utils.Constants;
import cn.thinkingdata.core.router.TRouterMap;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kuaishou.aegon.Aegon;
import com.kwad.components.offline.api.BuildConfig;
import com.kwad.sdk.DownloadTask;
import com.kwad.sdk.KsAdSDKImpl;
import com.kwad.sdk.core.config.e;
import com.kwad.sdk.core.report.t;
import com.kwad.sdk.crash.d;
import com.kwad.sdk.crash.f;
import com.kwad.sdk.crash.model.message.ExceptionMessage;
import com.kwad.sdk.crash.report.h;
import com.kwad.sdk.crash.utils.g;
import com.kwad.sdk.o;
import com.kwad.sdk.q;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bf;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.i;
import com.kwad.sdk.utils.n;
import com.kwai.CpuMemoryProfiler;
import java.io.File;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;
import java.util.concurrent.CopyOnWriteArrayList;
import java.util.concurrent.atomic.AtomicBoolean;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static boolean PI;
    private static boolean PJ;
    private static List<Throwable> PL;
    private static Map<String, String> PM;
    private static final AtomicBoolean mHasInit = new AtomicBoolean(false);
    private static final AtomicBoolean PK = new AtomicBoolean(false);
    private static final List<b> PN = new CopyOnWriteArrayList();
    private static final List<c> PO = new CopyOnWriteArrayList();

    public interface b {
        String getKey();

        JSONObject getValue();
    }

    public interface c {
        void onCrashOccur(int i, String str);
    }

    public static synchronized void initAsync(Context context) {
        if (context != null) {
            if (!mHasInit.get() && !PI) {
                PI = true;
                i.execute(new bi() { // from class: com.kwad.components.core.d.a.1
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        if (e.b(com.kwad.sdk.core.config.c.aNb)) {
                            com.kwad.sdk.core.d.c.d("KsAdExceptionCollectorHelper", "init");
                            com.kwad.sdk.crash.b.a(a.ph());
                            a.mHasInit.set(true);
                            a.pf();
                            a.pg();
                        }
                    }
                });
            }
        }
    }

    public static synchronized void am(Context context) {
        if (context != null) {
            if (!PK.get() && !PJ) {
                PJ = true;
                i.execute(new bi() { // from class: com.kwad.components.core.d.a.2
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        if (e.b(com.kwad.sdk.core.config.c.aNb)) {
                            com.kwad.sdk.core.d.c.d("KsAdExceptionCollectorHelper", "init Native");
                            com.kwad.sdk.crash.b.b(a.ph());
                            a.PK.set(true);
                        }
                    }
                });
            }
        }
    }

    public static void a(b bVar) {
        PN.add(bVar);
    }

    public static void a(c cVar) {
        PO.add(cVar);
    }

    public static void reportSdkCaughtException(Throwable th) {
        com.kwad.sdk.core.d.c.printStackTrace(th);
        if (!mHasInit.get()) {
            b(th);
        } else if (pe()) {
            com.kwad.sdk.crash.b.u(th);
        }
    }

    private static boolean pe() {
        return e.b(com.kwad.sdk.core.config.c.aNc);
    }

    public static void j(String str, String str2) {
        if (!mHasInit.get()) {
            k(str, str2);
        } else {
            h.aj(str, str2);
        }
    }

    private static void k(String str, String str2) {
        if (PM == null) {
            PM = new ConcurrentHashMap();
        }
        if (TextUtils.isEmpty(str)) {
            return;
        }
        PM.put(str, str2);
    }

    private static void b(Throwable th) {
        if (PL == null) {
            PL = new CopyOnWriteArrayList();
        }
        PL.add(th);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void pf() {
        if (PL == null || !pe()) {
            return;
        }
        Iterator<Throwable> it = PL.iterator();
        while (it.hasNext()) {
            com.kwad.sdk.crash.b.u(it.next());
        }
        PL.clear();
        PL = null;
        ServiceProvider.h(new com.kwad.sdk.g.a<Throwable>() { // from class: com.kwad.components.core.d.a.3
            @Override // com.kwad.sdk.g.a
            public final /* synthetic */ void accept(Throwable th) {
                c(th);
            }

            private static void c(Throwable th) {
                com.kwad.sdk.crash.b.u(th);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void pg() {
        Map<String, String> map = PM;
        if (map == null) {
            return;
        }
        for (Map.Entry<String, String> entry : map.entrySet()) {
            if (entry != null) {
                h.aj(entry.getKey(), entry.getValue());
            }
        }
        PM.clear();
    }

    private static com.kwad.sdk.crash.model.b ai(String str) {
        if (TextUtils.isEmpty(str)) {
            return new com.kwad.sdk.crash.model.b();
        }
        try {
            JSONObject jSONObject = new JSONObject(str);
            com.kwad.sdk.crash.model.b bVar = new com.kwad.sdk.crash.model.b();
            bVar.parseJson(jSONObject);
            return bVar;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.w("KsAdExceptionCollectorHelper", e);
            return new com.kwad.sdk.crash.model.b();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static com.kwad.sdk.crash.c ph() {
        String strA = e.a(com.kwad.sdk.core.config.c.aOA);
        com.kwad.sdk.core.d.c.d("KsAdExceptionCollectorHelper", "configStr:" + strA);
        com.kwad.sdk.crash.model.b bVarAi = ai(strA);
        String str = bVarAi.beI;
        String str2 = bVarAi.beJ;
        boolean zA = g.a(bVarAi);
        boolean zB = g.b(bVarAi);
        final Context context = ServiceProvider.getContext();
        String strAn = C0423a.an(context);
        com.kwad.sdk.crash.c.a aVarFU = new com.kwad.sdk.crash.c.a().cv(context).bW(zA).bX(zB).bY(o.GE().FG()).fV(str).fU(str2);
        o.GE();
        com.kwad.sdk.crash.c.a aVarGc = aVarFU.gc(ExceptionMessage.getSdkCrashVersionName(o.getSDKVersion(), 1));
        o.GE();
        return aVarGc.eL(BuildConfig.VERSION_CODE).gd(ExceptionMessage.getSdkCrashVersionName(o.GE().getApiVersion(), 1)).eM(o.GE().getApiVersionCode()).eN(1).gb("com.kwad.sdk").ge(context.getPackageName()).gf(ServiceProvider.getSDKConfig().appId).gg(ServiceProvider.getSDKConfig().appName).gh(n.cY(context)).gi(bVarAi.beE).gj(bVarAi.beF).fY(bf.getDeviceId()).fZ(ServiceProvider.getSDKConfig().appId).fX(bVarAi.version).gk(bVarAi.beH).gl(bVarAi.beG).fW(Constants.LOG_OS).ga(strAn).a(new com.kwad.sdk.crash.h() { // from class: com.kwad.components.core.d.a.5
            @Override // com.kwad.sdk.crash.h
            public final com.kwad.sdk.crash.model.message.a pq() {
                com.kwad.sdk.crash.model.message.a aVar = new com.kwad.sdk.crash.model.message.a();
                aVar.gq(t.Nt());
                aVar.putString("mKsadAppId", ServiceProvider.getSDKConfig().appId);
                aVar.putString("mKsadAppName", ServiceProvider.getSDKConfig().appName);
                aVar.putString("mKsadAppPackageName", context.getPackageName());
                aVar.putString("mKsadAppVersion", n.cY(context));
                aVar.putString("mKsadSdkName", "com.kwad.sdk");
                o.GE();
                aVar.putString("mKsadSdkVersion", ExceptionMessage.getSdkCrashVersionName(o.getSDKVersion(), 1));
                o.GE();
                aVar.putInt("mKsadSdKVersionCode", BuildConfig.VERSION_CODE);
                aVar.putString("mKsadSdkApiVersion", ExceptionMessage.getSdkCrashVersionName(o.GE().getApiVersion(), 1));
                aVar.putInt("mKsadSdKApiVersionCode", o.GE().getApiVersionCode());
                aVar.putInt("mKsadSdkType", 1);
                aVar.putInt("mBuildNumber", MediaPlayer.MEDIA_PLAYER_OPTION_LAST_AUDIO_DECODE_TIME);
                for (b bVar : a.PN) {
                    String key = bVar.getKey();
                    JSONObject value = bVar.getValue();
                    if (key != null && value != null) {
                        aVar.b(bVar.getKey(), bVar.getValue());
                    }
                }
                return aVar;
            }
        }).a(new f() { // from class: com.kwad.components.core.d.a.4
            @Override // com.kwad.sdk.crash.f
            public final void a(int i, ExceptionMessage exceptionMessage) {
                q.bg(context);
                if (i == 1 || i == 3 || i == 4) {
                    com.kwad.sdk.core.d.c.d("KsAdExceptionCollectorHelper", "onOccurred crashType=" + i);
                }
                Iterator it = a.PO.iterator();
                while (it.hasNext()) {
                    ((c) it.next()).onCrashOccur(i, exceptionMessage.mCrashDetail);
                }
            }
        }).d(pi()).e(pj()).N(e.JF()).k(e.a(com.kwad.sdk.core.config.c.aPJ)).Ql();
    }

    private static String[] pi() {
        ArrayList arrayList = new ArrayList();
        try {
            arrayList.add(aj(KsAdSDKImpl.class.getName()));
            arrayList.add(aj(DownloadTask.class.getName()));
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
        }
        try {
            arrayList.add(aj(CpuMemoryProfiler.class.getName()));
            arrayList.add(aj(Aegon.class.getName()));
        } catch (Throwable unused) {
        }
        return (String[]) arrayList.toArray(new String[arrayList.size()]);
    }

    private static String[] pj() {
        String[] strArr = new String[1];
        try {
            String name = d.class.getName();
            strArr[0] = name.substring(0, name.lastIndexOf(TRouterMap.DOT));
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
        }
        return strArr;
    }

    /* JADX INFO: renamed from: com.kwad.components.core.d.a$a, reason: collision with other inner class name */
    static class C0423a {
        public static String an(Context context) {
            File file = new File(getDataDir(context), "kwad_ex");
            if (!file.exists()) {
                file.mkdir();
            }
            return file.getAbsolutePath();
        }

        private static File getDataDir(Context context) {
            if (Build.VERSION.SDK_INT >= 29) {
                return new File(context.getExternalFilesDir(null).getAbsolutePath());
            }
            File dataDir = context.getDataDir();
            if (dataDir != null) {
                return dataDir;
            }
            File file = new File(Environment.getDataDirectory().getPath() + "/data/" + context.getPackageName());
            return !file.exists() ? new File("/data/data/" + context.getPackageName()) : file;
        }
    }

    private static String aj(String str) {
        try {
            int iIndexOf = str.indexOf(46, str.indexOf(46) + 1);
            if (iIndexOf > 0) {
                return str.substring(0, iIndexOf);
            }
            return null;
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            return null;
        }
    }
}
