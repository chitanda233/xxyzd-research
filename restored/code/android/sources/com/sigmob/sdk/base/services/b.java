package com.sigmob.sdk.base.services;

import android.content.Context;
import android.content.IntentFilter;
import android.content.pm.PackageInfo;
import android.os.Build;
import com.byazt.quv.AbsServerManager;
import com.czhj.sdk.common.Constants;
import com.czhj.sdk.common.ThreadPool.ThreadPoolFactory;
import com.czhj.sdk.common.utils.AppPackageUtil;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.i;
import com.sigmob.sdk.base.n;
import com.sigmob.sdk.base.o;
import com.sigmob.sdk.base.utils.h;
import com.sigmob.sdk.base.utils.y;
import com.sigmob.windad.WindAdOptions;
import com.sigmob.windad.WindAds;
import com.sigmob.windad.WindCustomController;
import java.util.Date;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class b implements f.a {
    private static final String c = "BuriedPointConfig";

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    a f3245a;
    g b = g.STOP;

    public b() {
        if (this.f3245a == null) {
            this.f3245a = new a();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(o oVar, Context context) {
        int i;
        List<String> listS = oVar.S();
        if (com.sigmob.sdk.base.utils.f.a(listS)) {
            return;
        }
        for (String str : listS) {
            boolean zB = false;
            if (oVar.J()) {
                zB = h.a(context, str);
                i = 0;
            } else if (oVar.K()) {
                zB = h.b(context, str);
                i = 1;
            } else {
                i = 0;
            }
            ad.a(str, zB, i);
        }
        c();
    }

    public static boolean a() {
        return y.a(com.sigmob.sdk.b.e(), c, n.c, "").equals(Constants.sdf.format(new Date()));
    }

    public static void b() {
        try {
            j();
        } catch (Throwable unused) {
        }
    }

    public static void c() {
        y.b(com.sigmob.sdk.b.e(), c, n.c, Constants.sdf.format(new Date()));
    }

    private static boolean c(Context context) {
        return y.a(context, c, n.b, "").equals(Constants.sdf.format(new Date()));
    }

    private static List<PackageInfo> d(Context context) {
        if (context == null) {
            return null;
        }
        try {
            return AppPackageUtil.getPackageManager(context).getInstalledPackages(0);
        } catch (Throwable unused) {
            return null;
        }
    }

    public static void d() {
        final Context contextE = com.sigmob.sdk.b.e();
        boolean zI = i.a().i();
        if (contextE == null || !zI) {
            return;
        }
        final o oVarA = o.a();
        if (a() || !oVarA.L().booleanValue()) {
            return;
        }
        ThreadPoolFactory.BackgroundThreadPool.getInstance().submit(new Runnable() { // from class: com.sigmob.sdk.base.services.b$$ExternalSyntheticLambda1
            @Override // java.lang.Runnable
            public final void run() {
                b.a(oVarA, contextE);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void e(Context context) {
        try {
            List<PackageInfo> listD = d(context);
            if (com.sigmob.sdk.base.utils.f.a(listD)) {
                return;
            }
            for (int i = 0; i < listD.size(); i++) {
                PackageInfo packageInfo = listD.get(i);
                if ((packageInfo.applicationInfo.flags & 1) == 0) {
                    ad.a(packageInfo, 0);
                }
            }
            y.b(context, c, n.b, Constants.sdf.format(new Date()));
        } catch (Throwable th) {
            SigmobLog.e("update app info", th);
        }
    }

    private static void i() {
        final Context contextE = com.sigmob.sdk.b.e();
        if (c(contextE)) {
            return;
        }
        ThreadPoolFactory.BackgroundThreadPool.getInstance().submit(new Runnable() { // from class: com.sigmob.sdk.base.services.b$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                b.e(contextE);
            }
        });
    }

    /* JADX WARN: Code duplicated, block: B:18:0x003e  */
    private static void j() {
        WindCustomController customController;
        try {
            if (i.a().i()) {
                WindAdOptions options = WindAds.sharedAds().getOptions();
                o oVarA = o.a();
                int iAb = oVarA.ab();
                boolean zJ = oVarA.j();
                boolean zQ = oVarA.Q();
                boolean z = false;
                if (!zJ) {
                    if (iAb == 1) {
                        z = true;
                    } else if (iAb != 2) {
                        if (((options == null || (customController = options.getCustomController()) == null) ? true : customController.isCanUseAppList()) && !zQ) {
                            z = true;
                        }
                    }
                }
                if (z) {
                    i();
                }
            }
        } catch (Throwable th) {
            SigmobLog.e("BuriedPointManager getInstance", th);
        }
    }

    public void a(Context context) {
        if (o.a().aa()) {
            return;
        }
        IntentFilter intentFilter = new IntentFilter();
        intentFilter.addAction(com.sigmob.sdk.base.utils.c.a(n.K));
        if (Build.VERSION.SDK_INT >= 27) {
            intentFilter.addAction(com.sigmob.sdk.base.utils.c.a(n.L));
        }
        intentFilter.addAction(com.sigmob.sdk.base.utils.c.a(n.I));
        intentFilter.addAction(com.sigmob.sdk.base.utils.c.a(n.H));
        intentFilter.addAction(com.sigmob.sdk.base.utils.c.a(n.J));
        intentFilter.addDataScheme(AbsServerManager.PACKAGE_QUERY_BINDER);
        h.a(context, this.f3245a, intentFilter);
    }

    public void b(Context context) {
        context.unregisterReceiver(this.f3245a);
    }

    @Override // com.sigmob.sdk.base.services.f.a
    public boolean e() {
        if (this.b == g.RUNNING) {
            return false;
        }
        a(com.sigmob.sdk.b.e());
        this.b = g.RUNNING;
        return true;
    }

    @Override // com.sigmob.sdk.base.services.f.a
    public g f() {
        return this.b;
    }

    @Override // com.sigmob.sdk.base.services.f.a
    public void g() {
        if (this.b == g.RUNNING) {
            b(com.sigmob.sdk.b.e());
            this.b = g.STOP;
        }
    }

    @Override // com.sigmob.sdk.base.services.f.a
    public Error h() {
        return null;
    }
}
