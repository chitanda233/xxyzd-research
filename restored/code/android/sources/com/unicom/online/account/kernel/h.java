package com.unicom.online.account.kernel;

import android.content.Context;
import android.net.Network;
import android.text.TextUtils;
import com.byazt.nys.PluginConstants;
import java.util.HashMap;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public final class h implements Runnable {
    public final /* synthetic */ Context b;
    public final /* synthetic */ Object c;
    public final /* synthetic */ int d;
    public final /* synthetic */ f e;
    public final /* synthetic */ i f;

    public h(i iVar, Context context, Object obj, int i, f fVar) {
        this.f = iVar;
        this.b = context;
        this.c = obj;
        this.d = i;
        this.e = fVar;
    }

    @Override // java.lang.Runnable
    public final void run() {
        try {
            boolean z = ap.b;
            s sVar = new s();
            Context context = this.b;
            Network network = (Network) this.c;
            if (sVar.f) {
                throw new IllegalStateException("ConnectionPoolManager已释放，不能再次使用");
            }
            sVar.e = context.getApplicationContext();
            sVar.d = network;
            ExecutorService executorService = sVar.c;
            if (executorService == null || executorService.isShutdown() || sVar.c.isTerminated()) {
                sVar.c = Executors.newCachedThreadPool();
            }
            sVar.c();
            int i = this.d;
            if (i != 2 && i != 3 && i != 4 && i != 5) {
                this.e.b(i, 410009, "410009no this type");
                return;
            }
            String str = ao.b(this.d) + aj.b(i.b(this.b, this.d));
            u.b().e = 0;
            Context context2 = this.b;
            i iVar = this.f;
            az azVar = new az(context2, iVar.f, sVar, iVar.d, this.d);
            as.b("CALL requestGetHttpsByConnectionPoolWithRetry:");
            Thread.currentThread().getId();
            Thread.currentThread().getName();
            Context context3 = this.b;
            HashMap map = new HashMap();
            map.put("user-agent", "Mozilla/5.0 (Linux; U; Android %s) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 %sSafari/533.1");
            map.put("netType", "2");
            map.put("os", "android");
            map.put("Accept", "*/*");
            String strB = ai.b(context3, str, map, this.c, azVar);
            try {
                if (new JSONObject(strB).optInt(PluginConstants.KEY_ERROR_CODE) != 100) {
                    Context context4 = this.b;
                    HashMap map2 = new HashMap();
                    map2.put("user-agent", "Mozilla/5.0 (Linux; U; Android %s) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 %sSafari/533.1");
                    map2.put("netType", "2");
                    map2.put("os", "android");
                    map2.put("Accept", "*/*");
                    strB = ai.c(context4, str, map2, this.c, 0, this.f.d);
                }
            } catch (JSONException unused) {
            }
            try {
                this.f.f.b();
                as.b("\ncall releaseNetwork() \n");
            } catch (Exception e) {
                as.b(e);
            }
            try {
                sVar.b();
                as.b("ConnectionPoolManager资源已释放");
            } catch (Exception e2) {
                as.b("释放ConnectionPoolManager资源失败: " + e2.getMessage());
                as.b(e2);
            }
            if (TextUtils.isEmpty(strB)) {
                Thread.currentThread().getId();
                this.e.b(this.d, 410002, "返回数据异常");
            } else {
                Thread.currentThread().getId();
                Thread.currentThread().getName();
                this.e.b(this.d, 1, strB);
            }
        } catch (Exception e3) {
            as.b(e3);
            this.e.b(this.d, 410009, "410009" + e3.getMessage());
        }
    }
}
