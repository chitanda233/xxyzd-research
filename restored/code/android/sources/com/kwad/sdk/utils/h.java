package com.kwad.sdk.utils;

import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.ServiceConnection;
import android.os.Bundle;
import android.os.Handler;
import android.os.IBinder;
import android.os.Looper;
import android.os.Message;
import android.os.Messenger;
import android.os.RemoteException;
import android.support.v4.media.session.PlaybackStateCompat;
import android.text.TextUtils;
import com.kwad.sdk.collector.AppStatusRules;
import com.kwad.sdk.core.threads.GlobalThreadPools;
import com.kwad.sdk.service.ServiceProvider;
import java.io.File;
import java.lang.ref.WeakReference;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Iterator;
import java.util.LinkedHashSet;
import java.util.List;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.ThreadPoolExecutor;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class h {
    private static Handler arV;
    private static WeakReference<Context> asb;
    private static Messenger bog;
    private static volatile ExecutorService boh;
    private static volatile AppStatusRules boi;
    private static com.kwad.sdk.collector.h boj;
    private static ServiceConnection serviceConnection = new ServiceConnection() { // from class: com.kwad.sdk.utils.h.1
        @Override // android.content.ServiceConnection
        public final void onServiceDisconnected(ComponentName componentName) {
        }

        @Override // android.content.ServiceConnection
        public final void onServiceConnected(ComponentName componentName, IBinder iBinder) {
            try {
                Messenger messenger = new Messenger(iBinder);
                Message messageObtain = Message.obtain();
                messageObtain.what = 100;
                if (h.Up()) {
                    messageObtain.replyTo = h.bog;
                    try {
                        messenger.send(messageObtain);
                        return;
                    } catch (RemoteException unused) {
                        return;
                    }
                }
                com.kwad.sdk.core.d.c.w("AppStatusHelper", "clientMessenger init error");
            } catch (SecurityException e) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(e);
                com.kwad.sdk.service.d.gatherException(e);
            }
        }
    };

    public interface b {
        void D(List<com.kwad.sdk.collector.model.b> list);
    }

    public static AppStatusRules Uo() {
        return boi;
    }

    public static void a(Context context, long j, com.kwad.sdk.collector.h hVar) {
        if (be.useStoragePermissionDisable() || com.kwad.sdk.core.config.e.al(PlaybackStateCompat.ACTION_PLAY_FROM_URI) || context == null || com.kwad.sdk.utils.d.cL(context)) {
            return;
        }
        boj = hVar;
        boolean zIsInMainProcess = SystemUtil.isInMainProcess(context);
        com.kwad.sdk.core.d.c.d("AppStatusHelper", "isMainProcess: " + zIsInMainProcess);
        if (zIsInMainProcess) {
            asb = new WeakReference<>(context);
            if (arV == null) {
                arV = new Handler(Looper.getMainLooper());
            }
            arV.postDelayed(new AnonymousClass2(context), 30000L);
        }
    }

    /* JADX INFO: renamed from: com.kwad.sdk.utils.h$2, reason: invalid class name */
    final class AnonymousClass2 extends bi {
        final /* synthetic */ Context dD;

        AnonymousClass2(Context context) {
            this.dD = context;
        }

        @Override // com.kwad.sdk.utils.bi
        public final void doTask() {
            com.kwad.sdk.collector.c.a(this.dD, new com.kwad.sdk.collector.c.a() { // from class: com.kwad.sdk.utils.h.2.1
                @Override // com.kwad.sdk.collector.c.a
                public final void b(AppStatusRules appStatusRules) {
                    appStatusRules.initStatus(AnonymousClass2.this.dD);
                    AppStatusRules unused = h.boi = appStatusRules;
                    h.b(AnonymousClass2.this.dD, h.boi);
                    h.cN(AnonymousClass2.this.dD);
                    boolean zED = bt.eD(AnonymousClass2.this.dD);
                    boolean zIsAppStatusTargetNotEmpty = AppStatusRules.isAppStatusTargetNotEmpty(h.boi);
                    com.kwad.sdk.core.d.c.d("AppStatusHelper", "appStatusTargetNotEmpty: " + zIsAppStatusTargetNotEmpty + ", permissionGranted: " + zED);
                    if (zED && zIsAppStatusTargetNotEmpty) {
                        long jObtainDefaultScanInterval = h.boi.obtainDefaultScanInterval();
                        if (jObtainDefaultScanInterval <= 0) {
                            h.cP(AnonymousClass2.this.dD);
                        } else {
                            h.c(AnonymousClass2.this.dD, jObtainDefaultScanInterval);
                        }
                    }
                    boolean zIsUploadTargetNotEmpty = AppStatusRules.isUploadTargetNotEmpty(h.boi);
                    boolean z = h.boi.obtainUploadConfigFileMaxSize() > 0;
                    com.kwad.sdk.core.d.c.d("AppStatusHelper", "uploadTargetNotEmpty: " + zIsUploadTargetNotEmpty + ", enableUpload: " + z);
                    if (zIsUploadTargetNotEmpty && z && zED) {
                        h.Uq();
                        h.boh.submit(new Runnable() { // from class: com.kwad.sdk.utils.h.2.1.1
                            @Override // java.lang.Runnable
                            public final void run() {
                                try {
                                    com.kwad.sdk.collector.j.a(AnonymousClass2.this.dD, h.boi);
                                } catch (Throwable th) {
                                    com.kwad.sdk.service.d.gatherException(th);
                                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                                }
                            }
                        });
                    }
                }

                @Override // com.kwad.sdk.collector.c.a
                public final void w(int i, String str) {
                    com.kwad.sdk.core.d.c.e("AppStatusHelper", "fetchAppStatusConfig onFetchError: " + str + ", code: " + i);
                }
            });
        }
    }

    public static void cN(Context context) {
        if (boi == null) {
            boi = cO(context);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static boolean Up() {
        if (bog == null) {
            try {
                bog = new Messenger(new c(Looper.getMainLooper()));
            } catch (Throwable unused) {
            }
        }
        return bog != null;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void b(Context context, AppStatusRules appStatusRules) {
        File file = new File(context.getFilesDir(), "LOCAL_APP_STATUS_RULES_JSON");
        String string = appStatusRules.toJson().toString();
        if (TextUtils.isEmpty(string)) {
            return;
        }
        com.kwad.sdk.crash.utils.h.k(file.getAbsolutePath(), com.kwad.sdk.core.a.c.encodeKsSdk(string), false);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void Uq() {
        if (boh == null) {
            synchronized (h.class) {
                if (boh == null) {
                    ExecutorService executorServiceOq = GlobalThreadPools.Oq();
                    boh = executorServiceOq;
                    com.kwad.sdk.core.threads.c.a((ThreadPoolExecutor) executorServiceOq, "appStatusHelper");
                }
            }
        }
    }

    private static AppStatusRules cO(Context context) {
        File file = new File(context.getFilesDir(), "LOCAL_APP_STATUS_RULES_JSON");
        if (!file.exists()) {
            return null;
        }
        try {
            String strJ = com.kwad.sdk.crash.utils.h.J(file);
            if (TextUtils.isEmpty(strJ)) {
                return null;
            }
            if (com.kwad.sdk.core.a.c.isEncodeKsSdk(strJ)) {
                strJ = com.kwad.sdk.core.a.c.decodeKsSdk(strJ);
            }
            JSONObject jSONObject = new JSONObject(strJ);
            AppStatusRules appStatusRules = new AppStatusRules();
            appStatusRules.parseJson(jSONObject);
            return appStatusRules;
        } catch (Throwable unused) {
            return null;
        }
    }

    public static void c(final Context context, final long j) {
        if (arV == null) {
            arV = new Handler(Looper.getMainLooper());
        }
        arV.post(new bi() { // from class: com.kwad.sdk.utils.h.3
            @Override // com.kwad.sdk.utils.bi
            public final void doTask() {
                h.cP(context);
                h.arV.postDelayed(this, j);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void cP(Context context) {
        if (context == null) {
            return;
        }
        boolean zUr = Ur();
        com.kwad.sdk.core.d.c.d("AppStatusHelper", "isServiceAvailable: " + zUr);
        if (zUr) {
            com.kwad.sdk.collector.b.a.a(context, serviceConnection);
        } else {
            a(context, new d(null));
        }
    }

    private static boolean Ur() {
        try {
            Class<?> cls = Class.forName("com.kwad.sdk.api.proxy.app.ServiceProxyRemote");
            if (cls != null) {
                Context context = ServiceProvider.getContext();
                return context.getPackageManager().queryIntentServices(new Intent(context, cls), 65536).size() > 0;
            }
        } catch (ClassNotFoundException e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
        }
        return false;
    }

    public static void a(final Context context, final b bVar) {
        if (context == null || be.useStoragePermissionDisable() || com.kwad.sdk.core.config.e.al(PlaybackStateCompat.ACTION_PLAY_FROM_URI) || com.kwad.sdk.utils.d.cL(context)) {
            return;
        }
        Uq();
        boh.submit(new Runnable() { // from class: com.kwad.sdk.utils.h.4
            @Override // java.lang.Runnable
            public final void run() {
                List listCQ;
                try {
                    HashSet hashSet = new HashSet();
                    if (!bt.eD(context) || (listCQ = h.cQ(context)) == null) {
                        return;
                    }
                    Iterator it = listCQ.iterator();
                    while (it.hasNext()) {
                        com.kwad.sdk.core.d.c.d("AppStatusHelper", "AppRunningInfo: " + ((com.kwad.sdk.collector.model.b) it.next()));
                    }
                    hashSet.addAll(listCQ);
                    if (bVar != null) {
                        bVar.D(new ArrayList(hashSet));
                    }
                } catch (Throwable th) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(th);
                    com.kwad.sdk.service.d.gatherException(th);
                }
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static List<com.kwad.sdk.collector.model.b> cQ(Context context) {
        if (!bt.eD(context)) {
            return new ArrayList();
        }
        if (boi == null) {
            boi = cO(context);
        }
        return cR(context);
    }

    private static List<com.kwad.sdk.collector.model.b> cR(Context context) {
        ArrayList arrayList = new ArrayList();
        if (be.useStoragePermissionDisable() || com.kwad.sdk.core.config.e.al(PlaybackStateCompat.ACTION_PLAY_FROM_URI) || com.kwad.sdk.utils.d.cL(context)) {
            return arrayList;
        }
        AppStatusRules appStatusRulesUo = Uo();
        for (AppStatusRules.Strategy strategy : com.kwad.sdk.collector.i.c(appStatusRulesUo)) {
            arrayList.addAll(a(strategy));
            strategy.setNeedSaveLaunchTime(System.currentTimeMillis());
        }
        AppStatusRules.Strategy strategyD = com.kwad.sdk.collector.i.d(appStatusRulesUo);
        arrayList.addAll(a(strategyD));
        strategyD.setNeedSaveLaunchTime(System.currentTimeMillis());
        return U(arrayList);
    }

    private static List<com.kwad.sdk.collector.model.b> a(AppStatusRules.Strategy strategy) {
        boolean zIsNeedLaunch = strategy.isNeedLaunch();
        com.kwad.sdk.core.d.c.d("AppStatusHelper", "analysisByFile, strategy: " + strategy.getName() + ", needLaunch: " + zIsNeedLaunch);
        if (!zIsNeedLaunch) {
            return new ArrayList();
        }
        return com.kwad.sdk.collector.b.Ij().a(strategy);
    }

    private static List<com.kwad.sdk.collector.model.b> U(List<com.kwad.sdk.collector.model.b> list) {
        return list.isEmpty() ? list : new ArrayList(new LinkedHashSet(list));
    }

    public static class a implements com.kwad.sdk.core.b {
        private String appName;
        private List<Long> bop = new ArrayList();
        private String packageName;

        private a(String str, String str2) {
            this.appName = str;
            this.packageName = str2;
        }

        public a() {
        }

        public static JSONArray V(List<com.kwad.sdk.collector.model.b> list) {
            List<a> listW;
            try {
                listW = W(list);
            } catch (Exception e) {
                com.kwad.sdk.service.d.gatherException(e);
                listW = null;
            }
            if (listW == null) {
                return null;
            }
            JSONArray jSONArray = new JSONArray();
            Iterator<a> it = listW.iterator();
            while (it.hasNext()) {
                jSONArray.put(it.next().toJson());
            }
            return jSONArray;
        }

        private static List<a> W(List<com.kwad.sdk.collector.model.b> list) {
            a aVar;
            if (list != null && list.size() != 0) {
                HashMap map = new HashMap();
                try {
                    for (com.kwad.sdk.collector.model.b bVar : list) {
                        String strB = com.kwad.sdk.collector.model.c.b(bVar);
                        if (map.containsKey(strB)) {
                            aVar = (a) map.get(strB);
                        } else {
                            a aVar2 = new a(com.kwad.sdk.collector.model.c.a(bVar), com.kwad.sdk.collector.model.c.b(bVar));
                            map.put(strB, aVar2);
                            aVar = aVar2;
                        }
                        long jC = com.kwad.sdk.collector.model.c.c(bVar) / 1000;
                        if (aVar != null) {
                            aVar.ba(jC);
                        }
                    }
                    return new ArrayList(map.values());
                } catch (ClassCastException e) {
                    com.kwad.sdk.core.d.c.printStackTraceOnly(e);
                }
            }
            return null;
        }

        private void ba(long j) {
            this.bop.add(Long.valueOf(j));
        }

        @Override // com.kwad.sdk.core.b
        public final void parseJson(JSONObject jSONObject) {
            if (jSONObject == null) {
                return;
            }
            this.appName = jSONObject.optString("appName");
            this.packageName = jSONObject.optString("packageName");
            JSONArray jSONArrayOptJSONArray = jSONObject.optJSONArray("runningTimes");
            if (jSONArrayOptJSONArray != null) {
                this.bop.clear();
                int length = jSONArrayOptJSONArray.length();
                for (int i = 0; i < length; i++) {
                    try {
                        this.bop.add(Long.valueOf(jSONArrayOptJSONArray.getLong(i)));
                    } catch (JSONException e) {
                        com.kwad.sdk.core.d.c.printStackTraceOnly(e);
                    }
                }
            }
        }

        @Override // com.kwad.sdk.core.b
        public final JSONObject toJson() {
            JSONObject jSONObject = new JSONObject();
            ac.putValue(jSONObject, "appName", this.appName);
            ac.putValue(jSONObject, "packageName", this.packageName);
            JSONArray jSONArray = new JSONArray();
            Iterator<Long> it = this.bop.iterator();
            while (it.hasNext()) {
                jSONArray.put(it.next().longValue());
            }
            ac.putValue(jSONObject, "runningTimes", jSONArray);
            return jSONObject;
        }
    }

    static class d implements b {
        private b bor = null;

        public d(b bVar) {
        }

        @Override // com.kwad.sdk.utils.h.b
        public final void D(List<com.kwad.sdk.collector.model.b> list) {
            JSONArray jSONArrayV = a.V(list);
            if (jSONArrayV != null) {
                h.boj.c(jSONArrayV);
            }
            b bVar = this.bor;
            if (bVar != null) {
                bVar.D(list);
            }
        }
    }

    static class c extends Handler {
        public c(Looper looper) {
            super(looper);
        }

        @Override // android.os.Handler
        public final void handleMessage(Message message) {
            super.handleMessage(message);
            if (message.what != 101) {
                return;
            }
            try {
                c(message);
            } catch (Throwable th) {
                com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            }
        }

        private void c(Message message) {
            ArrayList arrayList;
            List listA;
            Bundle data = message.getData();
            List<AppStatusRules.Strategy> listA2 = null;
            if (data != null) {
                try {
                    if (data.containsKey("resultJson")) {
                        listA = ac.a(data.getString("resultJson"), new com.kwad.sdk.core.c<a>() { // from class: com.kwad.sdk.utils.h.c.1
                            @Override // com.kwad.sdk.core.c
                            public final /* synthetic */ com.kwad.sdk.core.b IM() {
                                return UA();
                            }

                            private static a UA() {
                                return new a();
                            }
                        });
                        arrayList = null;
                    } else {
                        arrayList = (ArrayList) data.getSerializable("data");
                        listA = null;
                    }
                } catch (Throwable unused) {
                    arrayList = null;
                    listA = null;
                }
                if (arrayList != null) {
                    com.kwad.sdk.core.d.c.d("AppStatusHelper", "ClientHandler: handleMessage data size: " + arrayList.size());
                    c((ArrayList<com.kwad.sdk.collector.model.b>) arrayList);
                }
                if (listA != null) {
                    X(listA);
                }
            }
            if (h.asb != null && h.asb.get() != null && data != null) {
                if (data.containsKey("allStrategyJson")) {
                    String string = data.getString("allStrategyJson");
                    if (string != null) {
                        listA2 = ac.a(string, new com.kwad.sdk.core.c<AppStatusRules.Strategy>() { // from class: com.kwad.sdk.utils.h.c.2
                            @Override // com.kwad.sdk.core.c
                            public final /* synthetic */ com.kwad.sdk.core.b IM() {
                                return UB();
                            }

                            private static AppStatusRules.Strategy UB() {
                                return new AppStatusRules.Strategy();
                            }
                        });
                    }
                } else {
                    listA2 = (ArrayList) data.getSerializable("allStrategy");
                }
                if (listA2 != null) {
                    for (AppStatusRules.Strategy strategy : listA2) {
                        long needSaveLaunchTime = strategy.getNeedSaveLaunchTime();
                        if (needSaveLaunchTime >= 0) {
                            com.kwad.sdk.collector.i.a((Context) h.asb.get(), strategy, needSaveLaunchTime);
                        }
                    }
                }
            }
            if (h.asb == null || h.serviceConnection == null) {
                return;
            }
            com.kwad.sdk.core.d.c.d("AppStatusHelper", "unbindASService");
            com.kwad.sdk.collector.b.a.b((Context) h.asb.get(), h.serviceConnection);
        }

        private static void c(ArrayList<com.kwad.sdk.collector.model.b> arrayList) {
            JSONArray jSONArrayV;
            if (arrayList == null || (jSONArrayV = a.V(arrayList)) == null) {
                return;
            }
            h.boj.c(jSONArrayV);
        }

        private static void X(List<a> list) {
            if (list == null) {
                return;
            }
            h.boj.c(ac.Y(list));
        }
    }
}
