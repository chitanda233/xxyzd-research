package com.sigmob.sdk.base.services;

import android.app.DownloadManager;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.net.Uri;
import com.alipay.sdk.m.y.o;
import com.bytedance.pangle.provider.ContentProviderManager;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.utils.FileUtil;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.common.BaseBroadcastReceiver;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.common.ak;
import com.sigmob.sdk.base.common.h;
import com.sigmob.sdk.base.common.q;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.IntentActions;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.utils.n;
import com.sigmob.sdk.base.utils.s;
import com.sigmob.windad.WindAdError;
import java.io.File;
import java.util.HashMap;
import java.util.Locale;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
class c extends BroadcastReceiver {
    c() {
    }

    private void a(final Context context, final long downId, final Object object) {
        BaseAdUnit baseAdUnit;
        String str = "";
        if (object != null) {
            try {
                if (object instanceof BaseAdUnit) {
                    baseAdUnit = (BaseAdUnit) object;
                    try {
                        BaseAdUnit baseAdUnitC = h.c(baseAdUnit.getUuid());
                        if (baseAdUnitC != null) {
                            baseAdUnit = baseAdUnitC;
                        }
                    } catch (Exception unused) {
                    }
                } else {
                    if (object instanceof String) {
                        str = (String) object;
                    }
                    baseAdUnit = null;
                }
            } catch (Exception unused2) {
            }
        } else {
            baseAdUnit = null;
        }
        String str2 = str;
        BaseAdUnit baseAdUnit2 = baseAdUnit;
        Map<String, Object> mapA = q.a(downId);
        if (mapA == null) {
            return;
        }
        String str3 = (String) mapA.get("fileName");
        Object obj = mapA.get("status");
        Object obj2 = mapA.get(MediationConstant.KEY_REASON);
        if (obj == null || obj2 == null) {
            return;
        }
        int iIntValue = ((Integer) obj).intValue();
        int iIntValue2 = ((Integer) obj2).intValue();
        q.b(downId, str3);
        Uri uri = (Uri) mapA.get(ContentProviderManager.PROVIDER_URI);
        String str4 = "download info is null";
        if (uri == null || iIntValue != 8) {
            try {
                try {
                    str4 = String.format(Locale.getDefault(), "status %d, reason %d", Integer.valueOf(iIntValue), Integer.valueOf(iIntValue2));
                    try {
                        SigmobLog.i("handleDownloadComplete:fail:" + FileUtil.deleteFile(FileUtil.getRealFilePath(context, uri)));
                    } catch (Throwable th) {
                        th = th;
                        SigmobLog.e(th.getMessage());
                    }
                } catch (Throwable th2) {
                    th = th2;
                    str4 = "download info is null";
                }
            } catch (Throwable th3) {
                th = th3;
            }
            if (baseAdUnit2 != null) {
                ad.a(PointCategory.DOWNLOAD_FAILED, 2, str4, baseAdUnit2, (ad.a) null);
                ad.a(PointCategory.DOWNLOAD_END, "0", baseAdUnit2, (ad.a) null);
                HashMap map = new HashMap();
                map.put(o.c, "0");
                map.put("downloadId", Long.valueOf(downId));
                BaseBroadcastReceiver.a(context, baseAdUnit2.getUuid(), map, IntentActions.ACTION_INTERSTITIAL_DOWNLOAD_END);
            }
            try {
                ak.a(context, "下载失败", 0).show();
                return;
            } catch (Throwable th4) {
                SigmobLog.e(th4.getMessage());
                return;
            }
        }
        if (!s.a((CharSequence) str2)) {
            try {
                String realFilePath = FileUtil.getRealFilePath(context, uri);
                ad.a(baseAdUnit2, PointCategory.DOWNLOAD_END, ClientMetadata.getPackageInfoWithUri(context, realFilePath), "1");
                HashMap map2 = new HashMap();
                map2.put(o.c, "1");
                map2.put("downloadId", Long.valueOf(downId));
                q.a(context, realFilePath, baseAdUnit2);
                return;
            } catch (Throwable th5) {
                SigmobLog.e(th5.getMessage());
                ad.a(PointCategory.APP_INSTALL_START, WindAdError.ERROR_SIGMOB_INSTALL_FAIL.getErrorCode(), th5.getMessage(), baseAdUnit2, (ad.a) null);
                ad.a(PointCategory.APP_INSTALL_START, "0", baseAdUnit2, (ad.a) null);
                return;
            }
        }
        if (baseAdUnit2 != null) {
            com.sigmob.sdk.base.network.h.a(baseAdUnit2, com.sigmob.sdk.base.common.a.D);
            try {
                baseAdUnit2.enableUseDownloadApk(true);
                String realFilePath2 = FileUtil.getRealFilePath(context, uri);
                ad.a(baseAdUnit2, PointCategory.DOWNLOAD_END, ClientMetadata.getPackageInfoWithUri(context, realFilePath2), "1");
                HashMap map3 = new HashMap();
                map3.put(o.c, "1");
                map3.put("downloadId", Long.valueOf(downId));
                BaseBroadcastReceiver.a(context, baseAdUnit2.getUuid(), map3, IntentActions.ACTION_INTERSTITIAL_DOWNLOAD_END);
                q.a(context, realFilePath2, baseAdUnit2);
            } catch (Throwable th6) {
                SigmobLog.e(th6.getMessage());
                ad.a(PointCategory.APP_INSTALL_START, WindAdError.ERROR_SIGMOB_INSTALL_FAIL.getErrorCode(), th6.getMessage(), baseAdUnit2, (ad.a) null);
                ad.a(PointCategory.APP_INSTALL_START, "0", baseAdUnit2, (ad.a) null);
                ad.a(PointCategory.DOWNLOAD_FAILED, 2, "download info is null", baseAdUnit2, (ad.a) null);
                ad.a(PointCategory.DOWNLOAD_END, "0", baseAdUnit2, (ad.a) null);
                HashMap map4 = new HashMap();
                map4.put(o.c, "0");
                map4.put("downloadId", Long.valueOf(downId));
                BaseBroadcastReceiver.a(context, baseAdUnit2.getUuid(), map4, IntentActions.ACTION_INTERSTITIAL_DOWNLOAD_END);
            }
        }
    }

    DownloadManager a(Context context) {
        return (DownloadManager) context.getSystemService("download");
    }

    @Override // android.content.BroadcastReceiver
    public void onReceive(Context context, Intent intent) {
        long longExtra = intent.getLongExtra("extra_download_id", -1L);
        File fileA = n.a(Long.valueOf(longExtra));
        Object fromCache = FileUtil.readFromCache(fileA.getAbsolutePath());
        q.b(longExtra, "");
        FileUtil.deleteFile(fileA.getAbsolutePath());
        if (s.a((CharSequence) intent.getAction(), (CharSequence) "android.intent.action.DOWNLOAD_COMPLETE")) {
            a(context, longExtra, fromCache);
        }
    }
}
