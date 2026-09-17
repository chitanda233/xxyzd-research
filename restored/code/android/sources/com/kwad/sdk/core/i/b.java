package com.kwad.sdk.core.i;

import android.app.ActivityManager;
import android.content.Context;
import android.net.NetworkInfo;
import android.os.Debug;
import android.os.LocaleList;
import android.text.TextUtils;
import android.webkit.WebSettings;
import com.byazt.hv.TTDownloadField;
import com.kwad.sdk.utils.AbiUtil;
import com.kwad.sdk.utils.aq;
import com.kwad.sdk.utils.bt;
import com.kwad.sdk.utils.n;
import java.util.LinkedHashMap;
import java.util.Locale;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class b implements c {
    private static Locale aZf;
    private String aTY;
    private boolean aZd = true;
    private Map<String, String> aZe = new LinkedHashMap();

    private static long aJ(long j) {
        if (j > 524288000) {
            return 524288000L;
        }
        return j;
    }

    @Override // com.kwad.sdk.core.i.c
    public final void bJ(boolean z) {
        this.aZd = z;
    }

    @Override // com.kwad.sdk.core.i.c
    public final String OL() {
        return this.aZd ? "kwai-android aegon/4.6.3.1" : "kwai-android aegon/4.6.3";
    }

    @Override // com.kwad.sdk.core.i.c
    public final String cc(Context context) {
        return cf(context);
    }

    @Override // com.kwad.sdk.core.i.c
    public final String cd(Context context) {
        try {
            if (this.aZe.isEmpty()) {
                ce(context);
            }
            StringBuilder sbOM = OM();
            if (this.aZd) {
                sbOM.insert(0, " KRN/3.6.6");
            }
            return sbOM.toString();
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.w("KwaiUAGetter", "getWebViewUASuffix: " + th.getMessage());
            return "";
        }
    }

    private void ce(Context context) {
        this.aZe.put("Yoda", "3.2.11-rc1");
        this.aZe.put("Kwai", "11.8.10");
        this.aZe.put("OS_PRO_BIT", String.valueOf(AbiUtil.isArm64(context) ? 1 : 0));
        this.aZe.put("MAX_PHY_MEM", String.valueOf(bt.es(context) >> 20));
        this.aZe.put("KDT", "PHONE");
        this.aZe.put("AZPREFIX", "az4");
        this.aZe.put("ICFO", "0");
        this.aZe.put("StatusHT", String.valueOf(com.kwad.sdk.c.a.a.by(context)));
        this.aZe.put("TitleHT", "44");
        this.aZe.put("NetType", cg(context));
        this.aZe.put("ISLP", String.valueOf(ch(context)));
        this.aZe.put("ISDM", String.valueOf(ci(context)));
        int iEr = bt.er(context);
        this.aZe.put("ISLB", String.valueOf((iEr <= 0 || iEr >= 15) ? 0 : 1));
        this.aZe.put("locale", ON());
        this.aZe.put("SHP", String.valueOf(n.getScreenHeight(context)));
        this.aZe.put("SWP", String.valueOf(n.getScreenWidth(context)));
        this.aZe.put("SD", String.valueOf(n.de(context)));
        this.aZe.put("CD", "0");
        this.aZe.put("ISLM", String.valueOf(cj(context)));
    }

    private StringBuilder OM() {
        StringBuilder sb = new StringBuilder();
        for (Map.Entry<String, String> entry : this.aZe.entrySet()) {
            sb.append(" ").append(entry.getKey()).append("/").append(entry.getValue());
        }
        return sb;
    }

    private String cf(Context context) {
        if (!TextUtils.isEmpty(this.aTY)) {
            return this.aTY;
        }
        if (context == null) {
            return "";
        }
        try {
            if (!TextUtils.isEmpty(this.aTY)) {
                return this.aTY;
            }
            this.aTY = WebSettings.getDefaultUserAgent(context);
            return this.aTY;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(e);
        }
    }

    private static String cg(Context context) {
        NetworkInfo networkInfoDy;
        if (context == null || (networkInfoDy = aq.dy(context)) == null) {
            return "DISABLE";
        }
        int type = networkInfoDy.getType();
        if (type != 0) {
            return type != 1 ? "unknown" : "WIFI";
        }
        String subtypeName = networkInfoDy.getSubtypeName();
        return TextUtils.isEmpty(subtypeName) ? networkInfoDy.getTypeName() : subtypeName;
    }

    private static int ch(Context context) {
        return !AbiUtil.isArm64(context) || ((bt.es(context) >> 20) > 4096L ? 1 : ((bt.es(context) >> 20) == 4096L ? 0 : -1)) <= 0 ? 1 : 0;
    }

    private static int ci(Context context) {
        try {
            return (context.getResources().getConfiguration().uiMode & 48) == 32 ? 1 : 0;
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
            return 0;
        }
    }

    private static int cj(Context context) {
        ActivityManager activityManager = (ActivityManager) context.getSystemService(TTDownloadField.TT_ACTIVITY);
        ActivityManager.MemoryInfo memoryInfo = new ActivityManager.MemoryInfo();
        activityManager.getMemoryInfo(memoryInfo);
        return !memoryInfo.lowMemory && (memoryInfo.availMem > (aJ(memoryInfo.threshold) + aK(Debug.getPss())) ? 1 : (memoryInfo.availMem == (aJ(memoryInfo.threshold) + aK(Debug.getPss())) ? 0 : -1)) > 0 ? 0 : 1;
    }

    private static String ON() {
        Locale locale = LocaleList.getDefault().get(0);
        aZf = locale;
        if (locale == null) {
            aZf = Locale.CHINESE;
        }
        return aZf.getLanguage();
    }

    private static long aK(long j) {
        long j2;
        long j3 = j / 512000;
        if (j3 == 0) {
            return 524288000L;
        }
        if (j3 == 1) {
            j2 = j / 2;
        } else {
            j2 = j / 3;
        }
        return j2 * 1024;
    }
}
