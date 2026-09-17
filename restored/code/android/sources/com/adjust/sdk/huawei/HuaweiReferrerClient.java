package com.adjust.sdk.huawei;

import android.content.Context;
import android.database.Cursor;
import android.net.Uri;
import com.adjust.sdk.ILogger;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes.dex */
public class HuaweiReferrerClient {
    private static final int COLUMN_INDEX_CLICK_TIME = 1;
    private static final int COLUMN_INDEX_INSTALL_TIME = 2;
    private static final int COLUMN_INDEX_REFERRER = 0;
    private static final int COLUMN_INDEX_TRACK_ID = 4;
    private static final String REFERRER_PROVIDER_AUTHORITY = "com.huawei.appmarket.commondata";
    private static final String REFERRER_PROVIDER_URI = "content://com.huawei.appmarket.commondata/item/5";
    private static final AtomicBoolean shouldTryToReadHuaweiAdsReferrer = new AtomicBoolean(true);
    private static final AtomicBoolean shouldTryToReadHuaweiAppGalleryReferrer = new AtomicBoolean(true);

    public static HuaweiInstallReferrerResult getHuaweiAdsInstallReferrer(Context context, ILogger iLogger) {
        String string;
        AtomicBoolean atomicBoolean = shouldTryToReadHuaweiAdsReferrer;
        if (!atomicBoolean.get()) {
            iLogger.info("Should not try to read HuaweiAdsInstallReferrer", new Object[0]);
            return new HuaweiInstallReferrerResult("Should not try to read HuaweiAdsInstallReferrer");
        }
        if (!resolveContentProvider(context, REFERRER_PROVIDER_AUTHORITY)) {
            return new HuaweiInstallReferrerResult("HuaweiAdsInstallReferrer fail to resolve content provider");
        }
        Cursor cursorQuery = null;
        try {
            try {
                Uri uri = Uri.parse(REFERRER_PROVIDER_URI);
                cursorQuery = context.getContentResolver().query(uri, null, null, new String[]{context.getPackageName()}, null);
                if (cursorQuery == null || !cursorQuery.moveToFirst()) {
                    string = com.adjust.sdk.Util.formatString("HuaweiAdsInstallReferrer fail to read referrer for package [%s] and content uri [%s]", new Object[]{context.getPackageName(), uri.toString()});
                    iLogger.debug(string, new Object[0]);
                    atomicBoolean.set(false);
                    if (cursorQuery != null) {
                        cursorQuery.close();
                    }
                    return new HuaweiInstallReferrerResult(string);
                }
                String string2 = cursorQuery.getString(0);
                iLogger.debug("HuaweiAdsInstallReferrer index_referrer[%s]", new Object[]{string2});
                String string3 = cursorQuery.getString(1);
                String string4 = cursorQuery.getString(2);
                iLogger.debug("HuaweiAdsInstallReferrer clickTime[%s] installTime[%s]", new Object[]{string3, string4});
                long j = Long.parseLong(string3);
                long j2 = Long.parseLong(string4);
                if (isValidHuaweiAdsInstallReferrer(string2)) {
                    HuaweiInstallReferrerResult huaweiInstallReferrerResult = new HuaweiInstallReferrerResult(new HuaweiInstallReferrerDetails(string2, j, j2));
                    if (cursorQuery != null) {
                        cursorQuery.close();
                    }
                    return huaweiInstallReferrerResult;
                }
                HuaweiInstallReferrerResult huaweiInstallReferrerResult2 = new HuaweiInstallReferrerResult("Invalid HuaweiAdsInstallReferrer");
                if (cursorQuery != null) {
                    cursorQuery.close();
                }
                return huaweiInstallReferrerResult2;
            } catch (Exception e) {
                string = "HuaweiAdsInstallReferrer error [" + e.getMessage() + "]";
                iLogger.debug(string, new Object[0]);
                if (0 != 0) {
                }
            }
        } catch (Throwable th) {
            if (0 != 0) {
                cursorQuery.close();
            }
            throw th;
        }
    }

    /* JADX WARN: Code duplicated, block: B:23:0x0099 A[Catch: all -> 0x00bb, Exception -> 0x00be, TryCatch #4 {Exception -> 0x00be, all -> 0x00bb, blocks: (B:14:0x004b, B:16:0x0051, B:18:0x0080, B:22:0x0091, B:24:0x00b2, B:23:0x0099), top: B:46:0x004b }] */
    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r3v18 */
    /* JADX WARN: Type inference failed for: r3v19 */
    /* JADX WARN: Type inference failed for: r3v3 */
    /* JADX WARN: Type inference failed for: r3v4 */
    /* JADX WARN: Type inference failed for: r3v5, types: [android.database.Cursor] */
    /* JADX WARN: Type inference failed for: r3v7 */
    /* JADX WARN: Type inference failed for: r3v8, types: [java.lang.String] */
    /* JADX WARN: Type inference failed for: r3v9 */
    public static HuaweiInstallReferrerResult getHuaweiAppGalleryInstallReferrer(Context context, ILogger iLogger) throws Throwable {
        AtomicBoolean atomicBoolean = shouldTryToReadHuaweiAppGalleryReferrer;
        if (!atomicBoolean.get()) {
            iLogger.debug("Should not try to read HuaweiAppGalleryInstallReferrer", new Object[0]);
            return new HuaweiInstallReferrerResult("Should not try to read HuaweiAppGalleryInstallReferrer");
        }
        if (!resolveContentProvider(context, REFERRER_PROVIDER_AUTHORITY)) {
            return new HuaweiInstallReferrerResult("HuaweiAppGalleryInstallReferrer fail to resolve content provider");
        }
        ?? r3 = 0;
        String str = null;
        Cursor cursor = null;
        try {
            try {
                Uri uri = Uri.parse(REFERRER_PROVIDER_URI);
                Cursor cursorQuery = context.getContentResolver().query(uri, null, null, new String[]{context.getPackageName()}, null);
                if (cursorQuery != null) {
                    try {
                        if (cursorQuery.moveToFirst()) {
                            String string = cursorQuery.getString(4);
                            iLogger.debug("HuaweiAppGalleryInstallReferrer index_track_id[%s]", new Object[]{string});
                            String string2 = cursorQuery.getString(1);
                            String string3 = cursorQuery.getString(2);
                            iLogger.debug("HuaweiAppGalleryInstallReferrer clickTime[%s] installTime[%s]", new Object[]{string2, string3});
                            long j = Long.parseLong(string2);
                            long j2 = Long.parseLong(string3);
                            if (isValidHuaweiAppGalleryInstallReferrer(string)) {
                                HuaweiInstallReferrerResult huaweiInstallReferrerResult = new HuaweiInstallReferrerResult(new HuaweiInstallReferrerDetails(string, j, j2));
                                if (cursorQuery != null) {
                                    cursorQuery.close();
                                }
                                return huaweiInstallReferrerResult;
                            }
                            new HuaweiInstallReferrerResult("Invalid HuaweiAppGalleryInstallReferrer");
                        } else {
                            String string4 = com.adjust.sdk.Util.formatString("HuaweiAppGalleryInstallReferrer fail to read referrer for package [%s] and content uri [%s]", new Object[]{context.getPackageName(), uri.toString()});
                            iLogger.debug(string4, new Object[0]);
                            str = string4;
                        }
                    } catch (Exception e) {
                        e = e;
                        cursor = cursorQuery;
                        String str2 = "HuaweiAppGalleryInstallReferrer error [" + e.getMessage() + "]";
                        iLogger.debug(str2, new Object[0]);
                        if (cursor != null) {
                            cursor.close();
                        }
                        r3 = str2;
                    } catch (Throwable th) {
                        th = th;
                        r3 = cursorQuery;
                        if (r3 != 0) {
                            r3.close();
                        }
                        throw th;
                    }
                } else {
                    String string5 = com.adjust.sdk.Util.formatString("HuaweiAppGalleryInstallReferrer fail to read referrer for package [%s] and content uri [%s]", new Object[]{context.getPackageName(), uri.toString()});
                    iLogger.debug(string5, new Object[0]);
                    str = string5;
                }
                atomicBoolean.set(false);
                r3 = str;
                if (cursorQuery != null) {
                    cursorQuery.close();
                    r3 = str;
                }
            } catch (Throwable th2) {
                th = th2;
            }
        } catch (Exception e2) {
            e = e2;
        }
        return new HuaweiInstallReferrerResult((String) r3);
    }

    private static boolean resolveContentProvider(Context context, String str) {
        try {
            return context.getPackageManager().resolveContentProvider(str, 0) != null;
        } catch (Exception unused) {
            return false;
        }
    }

    private static boolean isValidHuaweiAdsInstallReferrer(String str) {
        return (str == null || str.isEmpty()) ? false : true;
    }

    private static boolean isValidHuaweiAppGalleryInstallReferrer(String str) {
        return (str == null || str.isEmpty()) ? false : true;
    }
}
