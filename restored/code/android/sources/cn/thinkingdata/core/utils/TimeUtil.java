package cn.thinkingdata.core.utils;

import android.text.TextUtils;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.HashMap;
import java.util.Locale;
import java.util.Map;
import java.util.TimeZone;

/* JADX INFO: loaded from: classes.dex */
public class TimeUtil {
    public static final String TIME_PATTERN = "yyyy-MM-dd HH:mm:ss.SSS";
    private static Map<String, ThreadLocal<SimpleDateFormat>> formatMaps = new HashMap();

    public static String formatDate(Date date, String str, TimeZone timeZone) {
        if (TextUtils.isEmpty(str)) {
            str = TIME_PATTERN;
        }
        SimpleDateFormat dateFormat = getDateFormat(str, timeZone);
        if (dateFormat == null) {
            return "";
        }
        try {
            return dateFormat.format(date);
        } catch (IllegalArgumentException e) {
            e.printStackTrace();
            return "";
        }
    }

    /* JADX WARN: Code duplicated, block: B:11:0x0037 A[Catch: all -> 0x0044, TryCatch #0 {, blocks: (B:6:0x0007, B:7:0x000b, B:9:0x002c, B:11:0x0037, B:12:0x003c), top: B:18:0x0007 }] */
    /* JADX WARN: Code duplicated, block: B:9:0x002c A[Catch: all -> 0x0044, TryCatch #0 {, blocks: (B:6:0x0007, B:7:0x000b, B:9:0x002c, B:11:0x0037, B:12:0x003c), top: B:18:0x0007 }] */
    private static synchronized SimpleDateFormat getDateFormat(final String str, final TimeZone timeZone) {
        String str2;
        ThreadLocal<SimpleDateFormat> threadLocal;
        String id = "";
        if (timeZone != null) {
            id = timeZone.getID();
            str2 = str + "_" + id;
            threadLocal = formatMaps.get(str2);
            if (threadLocal == null) {
                threadLocal = new ThreadLocal<SimpleDateFormat>() { // from class: cn.thinkingdata.core.utils.TimeUtil.1
                    /* JADX INFO: Access modifiers changed from: protected */
                    @Override // java.lang.ThreadLocal
                    public SimpleDateFormat initialValue() {
                        Exception e;
                        SimpleDateFormat simpleDateFormat;
                        try {
                            simpleDateFormat = new SimpleDateFormat(str, Locale.CHINA);
                            try {
                                TimeZone timeZone2 = timeZone;
                                if (timeZone2 != null) {
                                    simpleDateFormat.setTimeZone(timeZone2);
                                }
                            } catch (Exception e2) {
                                e = e2;
                                e.printStackTrace();
                            }
                        } catch (Exception e3) {
                            e = e3;
                            simpleDateFormat = null;
                        }
                        return simpleDateFormat;
                    }
                };
                if (threadLocal.get() != null) {
                    formatMaps.put(str2, threadLocal);
                }
            }
        } else {
            str2 = str + "_" + id;
            threadLocal = formatMaps.get(str2);
            if (threadLocal == null) {
                threadLocal = new ThreadLocal<SimpleDateFormat>() { // from class: cn.thinkingdata.core.utils.TimeUtil.1
                    /* JADX INFO: Access modifiers changed from: protected */
                    @Override // java.lang.ThreadLocal
                    public SimpleDateFormat initialValue() {
                        Exception e;
                        SimpleDateFormat simpleDateFormat;
                        try {
                            simpleDateFormat = new SimpleDateFormat(str, Locale.CHINA);
                            try {
                                TimeZone timeZone2 = timeZone;
                                if (timeZone2 != null) {
                                    simpleDateFormat.setTimeZone(timeZone2);
                                }
                            } catch (Exception e2) {
                                e = e2;
                                e.printStackTrace();
                            }
                        } catch (Exception e3) {
                            e = e3;
                            simpleDateFormat = null;
                        }
                        return simpleDateFormat;
                    }
                };
                if (threadLocal.get() != null) {
                    formatMaps.put(str2, threadLocal);
                }
            }
        }
        throw th;
        return threadLocal.get();
    }

    public static Date getFormatDate(String str, String str2, double d) {
        SimpleDateFormat dateFormat;
        if (!TextUtils.isEmpty(str2) && (dateFormat = getDateFormat(str2, getTimeZone(d))) != null) {
            try {
                return dateFormat.parse(str);
            } catch (Exception e) {
                e.printStackTrace();
                return new Date(0L);
            }
        }
        return new Date(0L);
    }

    public static TimeZone getTimeZone(double d) {
        String str;
        int i = (int) d;
        int i2 = (int) ((d - ((double) i)) * 60.0d);
        Locale locale = Locale.ROOT;
        Object[] objArr = new Object[2];
        if (i >= 0) {
            objArr[0] = Integer.valueOf(i);
            objArr[1] = Integer.valueOf(i2);
            str = String.format(locale, "GMT+%02d:%02d", objArr);
        } else {
            objArr[0] = Integer.valueOf(i);
            objArr[1] = Integer.valueOf(i2);
            str = String.format(locale, "GMT%02d:%02d", objArr);
        }
        return TimeZone.getTimeZone(str);
    }
}
