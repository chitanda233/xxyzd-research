package com.sigmob.sdk.base.services;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;
import android.net.Uri;
import android.util.Base64;
import com.alipay.sdk.m.y.o;
import com.czhj.sdk.common.ThreadPool.ThreadPoolFactory;
import com.czhj.sdk.common.utils.FileUtil;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.common.BaseBroadcastReceiver;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.common.ak;
import com.sigmob.sdk.base.i;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.IntentActions;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.network.h;
import com.sigmob.sdk.base.utils.k;
import com.sigmob.sdk.base.utils.n;
import com.sigmob.sdk.base.utils.s;
import com.sigmob.sdk.base.utils.v;
import com.sigmob.windad.WindAdError;
import java.io.File;
import java.util.HashMap;

/* JADX INFO: loaded from: classes3.dex */
class a extends BroadcastReceiver {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3244a = "a";

    a() {
    }

    private void a(Context context, PackageInfo info, String action) {
        ad.a((BaseAdUnit) null, PointCategory.APP_INSTALL_MONITOR, info, action);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static /* synthetic */ void a(Context context, BaseAdUnit baseAdUnit) {
        FileUtil.deleteFile(new File(n.a(context.getApplicationContext()), baseAdUnit.getApkName()).getAbsolutePath());
    }

    private void a(final Context context, final BaseAdUnit adUnit, PackageInfo info) {
        h.a(adUnit, com.sigmob.sdk.base.common.a.F);
        ad.a(adUnit, PointCategory.APP_INSTALL_END, info, "1");
        HashMap map = new HashMap();
        map.put(o.c, "1");
        BaseBroadcastReceiver.a(context, adUnit.getUuid(), map, IntentActions.ACTION_INTERSTITIAL_INSTALL_END);
        adUnit.setApkPackageName(info.packageName);
        ThreadPoolFactory.BackgroundThreadPool.getInstance().submit(new Runnable() { // from class: com.sigmob.sdk.base.services.a$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                a.a(context, adUnit);
            }
        });
        s.a((CharSequence) adUnit.getDeeplinkUrl());
    }

    protected String a(PackageManager pm, PackageInfo info) {
        if (pm != null && info != null) {
            try {
                String strValueOf = String.valueOf(pm.getApplicationLabel(info.applicationInfo));
                k.f(f3244a, "getAppLabel: label = " + strValueOf, new Object[0]);
                return strValueOf;
            } catch (Throwable th) {
                k.f(f3244a, "getAppLabel: error = " + th.getMessage(), new Object[0]);
            }
        }
        return null;
    }

    /* JADX WARN: Code duplicated, block: B:58:0x00dc  */
    /* JADX WARN: Failed to restore switch over string. Please report as a decompilation issue */
    @Override // android.content.BroadcastReceiver
    public void onReceive(Context context, Intent intent) {
        PackageInfo packageInfo;
        BaseAdUnit baseAdUnit;
        byte b;
        try {
            PackageManager packageManager = context.getPackageManager();
            Uri data = intent.getData();
            String action = intent.getAction();
            if (data != null && action != null) {
                String schemeSpecificPart = data.getSchemeSpecificPart();
                SigmobLog.d(String.format("onReceive: packageName = %s, action = %s", schemeSpecificPart, action));
                boolean booleanExtra = intent.getBooleanExtra("android.intent.extra.REPLACING", false);
                String strEncodeToString = Base64.encodeToString(action.getBytes(), 2);
                if (!strEncodeToString.equals(com.sigmob.sdk.base.n.H) || booleanExtra) {
                    try {
                        if (!i.a().i() || com.sigmob.sdk.base.o.a().Q()) {
                            packageInfo = null;
                        } else {
                            packageInfo = packageManager.getPackageInfo(schemeSpecificPart, 0);
                            try {
                                ad.a(packageInfo, 1);
                            } catch (Exception unused) {
                            }
                        }
                    } catch (Exception unused2) {
                    }
                    if (s.b(schemeSpecificPart)) {
                        String absolutePath = n.a((Object) schemeSpecificPart).getAbsolutePath();
                        Object fromCache = FileUtil.readFromCache(absolutePath);
                        if (v.b(fromCache) && (fromCache instanceof BaseAdUnit)) {
                            baseAdUnit = (BaseAdUnit) fromCache;
                            BaseAdUnit baseAdUnitC = com.sigmob.sdk.base.common.h.c(baseAdUnit.getUuid());
                            if (baseAdUnitC != null) {
                                baseAdUnit = baseAdUnitC;
                            }
                        } else {
                            baseAdUnit = null;
                        }
                        FileUtil.deleteFile(absolutePath);
                    } else {
                        baseAdUnit = null;
                    }
                    if (baseAdUnit == null) {
                        return;
                    }
                    String appName = baseAdUnit.getAppName();
                    if (s.a((CharSequence) appName)) {
                        String strA = a(packageManager, packageInfo);
                        if (!s.a((CharSequence) strA)) {
                            schemeSpecificPart = strA;
                        }
                        appName = schemeSpecificPart;
                    }
                    switch (strEncodeToString.hashCode()) {
                        case -1380358613:
                            if (!strEncodeToString.equals(com.sigmob.sdk.base.n.J)) {
                                b = -1;
                            } else {
                                b = 2;
                            }
                            break;
                        case -248756734:
                            if (!strEncodeToString.equals(com.sigmob.sdk.base.n.H)) {
                                b = -1;
                            } else {
                                b = 1;
                            }
                            break;
                        case 1293128098:
                            if (!strEncodeToString.equals(com.sigmob.sdk.base.n.I)) {
                                b = -1;
                            } else {
                                b = 0;
                            }
                            break;
                        case 1931663641:
                            if (!strEncodeToString.equals(com.sigmob.sdk.base.n.L)) {
                                b = -1;
                            } else {
                                b = 3;
                            }
                            break;
                        default:
                            b = -1;
                            break;
                    }
                    if (b != 0) {
                        if (b != 1) {
                            if (b != 2) {
                                if (b != 3) {
                                    return;
                                }
                                if (com.sigmob.sdk.base.n.f.booleanValue()) {
                                    ak.a(context, appName + " 安装失败", 0).show();
                                }
                                ad.a(baseAdUnit, PointCategory.APP_INSTALL_END, packageInfo, WindAdError.ERROR_SIGMOB_INSTALL_FAIL + ",System");
                                ad.a(PointCategory.APP_INSTALL_END, WindAdError.ERROR_SIGMOB_INSTALL_FAIL.getErrorCode(), "system", baseAdUnit, (ad.a) null);
                                HashMap map = new HashMap();
                                map.put(o.c, "0");
                                BaseBroadcastReceiver.a(context, baseAdUnit.getUuid(), map, IntentActions.ACTION_INTERSTITIAL_INSTALL_END);
                                return;
                            }
                            if (com.sigmob.sdk.base.n.f.booleanValue()) {
                                ak.a(context, appName + " 替换成功", 1).show();
                            }
                        } else {
                            if (!booleanExtra) {
                                if (com.sigmob.sdk.base.n.f.booleanValue()) {
                                    ak.a(context, appName + " 卸载成功", 1).show();
                                    return;
                                }
                                return;
                            }
                            ak.a(context, appName + " 替换成功", 1).show();
                        }
                    } else if (com.sigmob.sdk.base.n.f.booleanValue()) {
                        ak.a(context, appName + " 安装成功", 1).show();
                    }
                    a(context, baseAdUnit, packageInfo);
                    return;
                }
                return;
            }
            SigmobLog.e("data or action is null");
        } catch (Throwable th) {
            SigmobLog.e(th.getMessage());
        }
    }
}
