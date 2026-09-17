package cn.thinkingdata.analytics.h;

import android.app.ActionBar;
import android.app.Activity;
import android.app.ActivityManager;
import android.content.Context;
import android.content.pm.ActivityInfo;
import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;
import android.os.Handler;
import android.text.TextUtils;
import android.util.Pair;
import android.view.Choreographer;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewParent;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.CheckedTextView;
import android.widget.CompoundButton;
import android.widget.ImageView;
import android.widget.RadioButton;
import android.widget.TextView;
import android.widget.ToggleButton;
import cn.thinkingdata.analytics.R;
import cn.thinkingdata.analytics.ScreenAutoTracker;
import cn.thinkingdata.analytics.TDPresetProperties;
import cn.thinkingdata.analytics.ThinkingDataFragmentTitle;
import cn.thinkingdata.core.utils.ProcessUtil;
import cn.thinkingdata.core.utils.TimeUtil;
import com.byazt.hv.TTDownloadField;
import com.bykv.vk.component.ttvideo.player.C;
import java.io.File;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Collections;
import java.util.Date;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Locale;
import java.util.TimeZone;
import java.util.regex.Pattern;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class q {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    static long f126a;
    static long b;
    static volatile int c;
    static final Object d = new Object();

    class a implements Choreographer.FrameCallback {
        a() {
        }

        @Override // android.view.Choreographer.FrameCallback
        public void doFrame(long j) {
            synchronized (q.d) {
                q.b = j;
                if (j <= q.f126a) {
                    q.c = 60;
                } else {
                    try {
                        long j2 = C.NANOS_PER_SECOND / (q.b - q.f126a);
                        if (j2 > 70) {
                            q.c = 60;
                        } else {
                            q.c = (int) j2;
                        }
                    } catch (Exception unused) {
                        q.c = 60;
                    }
                }
            }
        }
    }

    class b implements Choreographer.FrameCallback {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ Choreographer.FrameCallback f127a;

        b(Choreographer.FrameCallback frameCallback) {
            this.f127a = frameCallback;
        }

        @Override // android.view.Choreographer.FrameCallback
        public void doFrame(long j) {
            synchronized (q.d) {
                q.f126a = j;
                Choreographer.getInstance().postFrameCallback(this.f127a);
            }
        }
    }

    class c implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ Handler f128a;
        final /* synthetic */ Choreographer.FrameCallback b;

        c(Handler handler, Choreographer.FrameCallback frameCallback) {
            this.f128a = handler;
            this.b = frameCallback;
        }

        @Override // java.lang.Runnable
        public void run() {
            this.f128a.postDelayed(this, 500L);
            Choreographer.getInstance().postFrameCallback(this.b);
        }
    }

    public static double a(double d2) {
        return Math.round(d2 * 10.0d) / 10.0d;
    }

    public static double a(long j, TimeZone timeZone) {
        if (timeZone == null) {
            timeZone = TimeZone.getDefault();
        }
        return ((double) timeZone.getOffset(j)) / 3600000.0d;
    }

    public static float a(float f, int i) {
        int i2 = 1;
        for (int i3 = 0; i3 < i; i3++) {
            i2 *= 10;
        }
        float f2 = i2;
        return Math.round(f * f2) / f2;
    }

    public static int a() {
        if (c == 0) {
            c = 60;
        }
        return c;
    }

    private static int a(ViewParent viewParent, View view) {
        try {
            if (!(viewParent instanceof ViewGroup)) {
                return -1;
            }
            ViewGroup viewGroup = (ViewGroup) viewParent;
            String strA = a(view);
            String canonicalName = view.getClass().getCanonicalName();
            int i = 0;
            for (int i2 = 0; i2 < viewGroup.getChildCount(); i2++) {
                View childAt = viewGroup.getChildAt(i2);
                if (f.a(childAt, canonicalName)) {
                    String strA2 = a(childAt);
                    if ((strA == null || strA.equals(strA2)) && childAt == view) {
                        return i;
                    }
                    i++;
                }
            }
            return -1;
        } catch (Exception e) {
            e.printStackTrace();
            return -1;
        }
    }

    public static int a(String str) {
        if ("NULL".equals(str)) {
            return 255;
        }
        if ("WIFI".equals(str)) {
            return 8;
        }
        if ("2G".equals(str)) {
            return 1;
        }
        if ("3G".equals(str)) {
            return 2;
        }
        if ("4G".equals(str)) {
            return 4;
        }
        return "5G".equals(str) ? 16 : 255;
    }

    /* JADX WARN: Code restructure failed: missing block: B:14:0x001c, code lost:
    
        if ((r1 instanceof android.app.Activity) != false) goto L15;
     */
    /*
        Code decompiled incorrectly, please refer to instructions dump.
        To view partially-correct add '--show-bad-code' argument
    */
    public static android.app.Activity a(android.content.Context r1) {
        /*
            if (r1 == 0) goto L25
            boolean r0 = r1 instanceof android.app.Activity     // Catch: java.lang.Exception -> L21
            if (r0 == 0) goto L7
            goto L1e
        L7:
            boolean r0 = r1 instanceof android.content.ContextWrapper     // Catch: java.lang.Exception -> L21
            if (r0 == 0) goto L25
        Lb:
            boolean r0 = r1 instanceof android.app.Activity     // Catch: java.lang.Exception -> L21
            if (r0 != 0) goto L1a
            boolean r0 = r1 instanceof android.content.ContextWrapper     // Catch: java.lang.Exception -> L21
            if (r0 == 0) goto L1a
            android.content.ContextWrapper r1 = (android.content.ContextWrapper) r1     // Catch: java.lang.Exception -> L21
            android.content.Context r1 = r1.getBaseContext()     // Catch: java.lang.Exception -> L21
            goto Lb
        L1a:
            boolean r0 = r1 instanceof android.app.Activity     // Catch: java.lang.Exception -> L21
            if (r0 == 0) goto L25
        L1e:
            android.app.Activity r1 = (android.app.Activity) r1     // Catch: java.lang.Exception -> L21
            goto L26
        L21:
            r1 = move-exception
            r1.printStackTrace()
        L25:
            r1 = 0
        L26:
            return r1
        */
        throw new UnsupportedOperationException("Method not decompiled: cn.thinkingdata.analytics.h.q.a(android.content.Context):android.app.Activity");
    }

    public static synchronized Object a(String str, View view, int i) {
        HashMap map = (HashMap) view.getTag(i);
        if (map == null) {
            return null;
        }
        return map.get(str);
    }

    public static String a(Activity activity) {
        PackageManager packageManager;
        if (activity != null) {
            try {
                String string = !TextUtils.isEmpty(activity.getTitle()) ? activity.getTitle().toString() : null;
                String strB = b(activity);
                if (!TextUtils.isEmpty(strB)) {
                    string = strB;
                }
                if (!TextUtils.isEmpty(string) || (packageManager = activity.getPackageManager()) == null) {
                    return string;
                }
                ActivityInfo activityInfo = packageManager.getActivityInfo(activity.getComponentName(), 0);
                return !TextUtils.isEmpty(activityInfo.loadLabel(packageManager)) ? activityInfo.loadLabel(packageManager).toString() : string;
            } catch (Exception unused) {
            }
        }
        return null;
    }

    public static String a(View view) {
        return a(view, (String) null);
    }

    public static String a(View view, String str) {
        try {
            String str2 = (String) a(str, view, R.id.thinking_analytics_tag_view_id);
            try {
                return (!TextUtils.isEmpty(str2) || view.getId() == -1) ? str2 : view.getContext().getResources().getResourceEntryName(view.getId());
            } catch (Exception unused) {
                return str2;
            }
        } catch (Exception unused2) {
            return null;
        }
    }

    public static String a(Object obj, String str) {
        ThinkingDataFragmentTitle thinkingDataFragmentTitle;
        JSONObject trackProperties;
        String strOptString = null;
        try {
            if ((obj instanceof ScreenAutoTracker) && (trackProperties = ((ScreenAutoTracker) obj).getTrackProperties()) != null && trackProperties.has("#title")) {
                strOptString = trackProperties.optString("#title");
            }
            if (TextUtils.isEmpty(strOptString) && obj.getClass().isAnnotationPresent(ThinkingDataFragmentTitle.class) && (thinkingDataFragmentTitle = (ThinkingDataFragmentTitle) obj.getClass().getAnnotation(ThinkingDataFragmentTitle.class)) != null) {
                return (TextUtils.isEmpty(thinkingDataFragmentTitle.appId()) || str.equals(thinkingDataFragmentTitle.appId())) ? thinkingDataFragmentTitle.title() : strOptString;
            }
            return strOptString;
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }

    public static String a(String str, int i) {
        return (!TextUtils.isEmpty(str) && str.length() > i) ? str.substring(str.length() - 4) : str;
    }

    /* JADX WARN: Code duplicated, block: B:63:0x00d8 A[Catch: Exception -> 0x00ed, TryCatch #1 {Exception -> 0x00ed, blocks: (B:4:0x0004, B:6:0x0009, B:8:0x0011, B:64:0x00e4, B:11:0x001d, B:13:0x0021, B:21:0x0035, B:23:0x0039, B:61:0x00d2, B:63:0x00d8, B:26:0x0044, B:28:0x004a, B:30:0x0053, B:32:0x0059, B:36:0x006c, B:33:0x0060, B:35:0x0066, B:37:0x0076, B:39:0x007a, B:40:0x0081, B:42:0x0085, B:44:0x008d, B:45:0x0092, B:46:0x0097, B:48:0x009b, B:49:0x00a2, B:51:0x00a6, B:52:0x00ad, B:54:0x00b1, B:55:0x00b8, B:57:0x00bc, B:59:0x00c8, B:65:0x00e8), top: B:73:0x0002 }] */
    /* JADX WARN: Code duplicated, block: B:79:0x00e4 A[SYNTHETIC] */
    public static String a(StringBuilder sb, ViewGroup viewGroup) {
        Class<?> cls;
        CharSequence string;
        CharSequence text;
        try {
            if (viewGroup == null) {
                return sb.toString();
            }
            int childCount = viewGroup.getChildCount();
            for (int i = 0; i < childCount; i++) {
                View childAt = viewGroup.getChildAt(i);
                if (childAt.getVisibility() == 0) {
                    if (childAt instanceof ViewGroup) {
                        a(sb, (ViewGroup) childAt);
                    } else {
                        CharSequence charSequence = null;
                        try {
                            cls = Class.forName("androidx.appcompat.widget.SwitchCompat");
                        } catch (Exception unused) {
                            cls = null;
                        }
                        if (cls == null) {
                            try {
                                cls = Class.forName("androidx.appcompat.widget.SwitchCompat");
                            } catch (Exception unused2) {
                            }
                        }
                        if (childAt instanceof CheckBox) {
                            text = ((CheckBox) childAt).getText();
                        } else {
                            if (cls == null || !cls.isInstance(childAt)) {
                                if (childAt instanceof RadioButton) {
                                    text = ((RadioButton) childAt).getText();
                                } else if (childAt instanceof ToggleButton) {
                                    ToggleButton toggleButton = (ToggleButton) childAt;
                                    string = toggleButton.isChecked() ? toggleButton.getTextOn() : toggleButton.getTextOff();
                                } else if (childAt instanceof Button) {
                                    string = ((Button) childAt).getText();
                                } else if (childAt instanceof CheckedTextView) {
                                    string = ((CheckedTextView) childAt).getText();
                                } else if (childAt instanceof TextView) {
                                    string = ((TextView) childAt).getText();
                                } else if (childAt instanceof ImageView) {
                                    ImageView imageView = (ImageView) childAt;
                                    if (!TextUtils.isEmpty(imageView.getContentDescription())) {
                                        string = imageView.getContentDescription().toString();
                                    }
                                }
                                if (!TextUtils.isEmpty(string)) {
                                    sb.append(string.toString());
                                    sb.append("-");
                                }
                            } else {
                                charSequence = (String) (((CompoundButton) childAt).isChecked() ? childAt.getClass().getMethod("getTextOn", new Class[0]) : childAt.getClass().getMethod("getTextOff", new Class[0])).invoke(childAt, new Object[0]);
                            }
                            string = charSequence;
                            if (!TextUtils.isEmpty(string)) {
                                sb.append(string.toString());
                                sb.append("-");
                            }
                        }
                        charSequence = text;
                        string = charSequence;
                        if (!TextUtils.isEmpty(string)) {
                            sb.append(string.toString());
                            sb.append("-");
                        }
                    }
                }
            }
            return sb.toString();
        } catch (Exception e) {
            e.printStackTrace();
            return sb.toString();
        }
    }

    public static String a(Date date, TimeZone timeZone) {
        Calendar calendar = Calendar.getInstance(Locale.CHINA);
        calendar.setTimeZone(timeZone);
        calendar.setTime(date);
        Locale locale = Locale.CHINA;
        Object[] objArr = new Object[7];
        objArr[0] = Integer.valueOf(calendar.get(1));
        objArr[1] = Integer.valueOf(calendar.get(2) + 1);
        objArr[2] = Integer.valueOf(calendar.get(5));
        objArr[3] = Integer.valueOf(calendar.get(9) == 0 ? calendar.get(10) : calendar.get(10) + 12);
        objArr[4] = Integer.valueOf(calendar.get(12));
        objArr[5] = Integer.valueOf(calendar.get(13));
        objArr[6] = Integer.valueOf(calendar.get(14));
        return String.format(locale, "%04d-%02d-%02d %02d:%02d:%02d.%3d", objArr);
    }

    public static JSONArray a(JSONArray jSONArray, TimeZone timeZone) {
        JSONArray jSONArray2 = new JSONArray();
        for (int i = 0; i < jSONArray.length(); i++) {
            Object objOpt = jSONArray.opt(i);
            if (objOpt != null) {
                if (objOpt instanceof Date) {
                    SimpleDateFormat simpleDateFormat = new SimpleDateFormat(TimeUtil.TIME_PATTERN, Locale.CHINA);
                    if (timeZone != null) {
                        simpleDateFormat.setTimeZone(timeZone);
                    }
                    Date date = (Date) objOpt;
                    String strA = simpleDateFormat.format(date);
                    if (!Pattern.compile("\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}\\.\\d{3}").matcher(strA).find()) {
                        strA = a(date, timeZone);
                    }
                    jSONArray2.put(strA);
                } else {
                    if (objOpt instanceof JSONArray) {
                        objOpt = a((JSONArray) objOpt, timeZone);
                    } else if (objOpt instanceof JSONObject) {
                        objOpt = a((JSONObject) objOpt, timeZone);
                    }
                    jSONArray2.put(objOpt);
                }
            }
        }
        return jSONArray2;
    }

    public static JSONObject a(JSONObject jSONObject, TimeZone timeZone) {
        JSONObject jSONObject2 = new JSONObject();
        Iterator<String> itKeys = jSONObject.keys();
        while (itKeys.hasNext()) {
            String next = itKeys.next();
            try {
                Object objA = jSONObject.get(next);
                if (objA instanceof Date) {
                    SimpleDateFormat simpleDateFormat = new SimpleDateFormat(TimeUtil.TIME_PATTERN, Locale.CHINA);
                    if (timeZone != null) {
                        simpleDateFormat.setTimeZone(timeZone);
                    }
                    String strA = simpleDateFormat.format((Date) objA);
                    if (!Pattern.compile("\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}\\.\\d{3}").matcher(strA).find()) {
                        strA = a((Date) objA, timeZone);
                    }
                    jSONObject2.put(next, strA);
                } else {
                    if (objA instanceof JSONArray) {
                        objA = a((JSONArray) objA, timeZone);
                    } else if (objA instanceof JSONObject) {
                        objA = a((JSONObject) objA, timeZone);
                    }
                    jSONObject2.put(next, objA);
                }
            } catch (JSONException e) {
                e.printStackTrace();
            }
        }
        return jSONObject2;
    }

    public static void a(Activity activity, View view, JSONObject jSONObject) {
        ViewParent parent;
        if (view == null) {
            return;
        }
        if (jSONObject == null) {
            try {
                jSONObject = new JSONObject();
            } catch (Exception e) {
                e.printStackTrace();
                return;
            }
        }
        ArrayList arrayList = new ArrayList();
        do {
            parent = view.getParent();
            arrayList.add(view.getClass().getCanonicalName() + "[" + a(parent, view) + "]");
            if (parent instanceof ViewGroup) {
                view = (ViewGroup) parent;
            }
        } while (parent instanceof ViewGroup);
        Collections.reverse(arrayList);
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i < arrayList.size(); i++) {
            sb.append((String) arrayList.get(i));
            if (i != arrayList.size() - 1) {
                sb.append("/");
            }
        }
        if (TDPresetProperties.disableList.contains("#element_selector")) {
            return;
        }
        jSONObject.put("#element_selector", sb.toString());
    }

    public static void a(View view, JSONObject jSONObject) {
        if (view != null) {
            try {
                String str = (String) view.getTag(R.id.thinking_analytics_tag_view_fragment_name);
                if (TextUtils.isEmpty(str) && view.getParent() != null && (view.getParent() instanceof View)) {
                    str = (String) ((View) view.getParent()).getTag(R.id.thinking_analytics_tag_view_fragment_name);
                }
                if (TextUtils.isEmpty(str)) {
                    return;
                }
                String strOptString = jSONObject.optString("#screen_name");
                if (TextUtils.isEmpty(str)) {
                    if (TDPresetProperties.disableList.contains("#screen_name")) {
                        return;
                    }
                    jSONObject.put("#screen_name", str);
                } else {
                    if (TDPresetProperties.disableList.contains("#screen_name")) {
                        return;
                    }
                    jSONObject.put("#screen_name", String.format(Locale.CHINA, "%s|%s", strOptString, str));
                }
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }

    public static synchronized void a(String str, View view, int i, Object obj) {
        if (str == null) {
            return;
        }
        HashMap map = (HashMap) view.getTag(i);
        if (map == null) {
            map = new HashMap();
        }
        map.put(str, obj);
        view.setTag(i, map);
    }

    public static void a(JSONObject jSONObject, Activity activity) {
        PackageManager packageManager;
        if (activity == null || jSONObject == null) {
            return;
        }
        try {
            if (!TDPresetProperties.disableList.contains("#screen_name")) {
                jSONObject.put("#screen_name", activity.getClass().getCanonicalName());
            }
            String string = activity.getTitle().toString();
            String strB = b(activity);
            if (!TextUtils.isEmpty(strB)) {
                string = strB;
            }
            if (TextUtils.isEmpty(string) && (packageManager = activity.getPackageManager()) != null) {
                string = packageManager.getActivityInfo(activity.getComponentName(), 0).loadLabel(packageManager).toString();
            }
            if (TextUtils.isEmpty(string) || TDPresetProperties.disableList.contains("#title")) {
                return;
            }
            jSONObject.put("#title", string);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static void a(JSONObject jSONObject, JSONObject jSONObject2, TimeZone timeZone) {
        if (jSONObject == null || jSONObject2 == null) {
            return;
        }
        Iterator<String> itKeys = jSONObject.keys();
        while (itKeys.hasNext()) {
            String next = itKeys.next();
            Object objA = jSONObject.get(next);
            if (objA instanceof Date) {
                SimpleDateFormat simpleDateFormat = new SimpleDateFormat(TimeUtil.TIME_PATTERN, Locale.CHINA);
                if (timeZone != null) {
                    simpleDateFormat.setTimeZone(timeZone);
                }
                Date date = (Date) objA;
                String strA = simpleDateFormat.format(date);
                if (!Pattern.compile("\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}\\.\\d{3}").matcher(strA).find()) {
                    strA = a(date, timeZone);
                }
                jSONObject2.put(next, strA);
            } else {
                if (objA instanceof JSONArray) {
                    objA = a((JSONArray) objA, timeZone);
                } else if (objA instanceof JSONObject) {
                    objA = a((JSONObject) objA, timeZone);
                }
                jSONObject2.put(next, objA);
            }
        }
    }

    public static String b(Activity activity) {
        Class<?> cls;
        Object objInvoke;
        CharSequence charSequence;
        ActionBar actionBar = activity.getActionBar();
        if (actionBar == null) {
            try {
                cls = Class.forName("androidx.appcompat.app.AppCompatActivity");
            } catch (Throwable unused) {
                cls = null;
            }
            if (cls == null) {
                try {
                    cls = Class.forName("androidx.appcompat.app.AppCompatActivity");
                } catch (Throwable unused2) {
                }
            }
            if (cls != null) {
                try {
                    if (cls.isInstance(activity) && (objInvoke = activity.getClass().getMethod("getSupportActionBar", new Class[0]).invoke(activity, new Object[0])) != null && (charSequence = (CharSequence) objInvoke.getClass().getMethod("getTitle", new Class[0]).invoke(objInvoke, new Object[0])) != null) {
                        return charSequence.toString();
                    }
                } catch (Throwable unused3) {
                }
            }
        } else if (!TextUtils.isEmpty(actionBar.getTitle())) {
            return actionBar.getTitle().toString();
        }
        return null;
    }

    public static String b(Context context) {
        try {
            return ProcessUtil.getCurrentProcessName(context);
        } catch (Exception e) {
            e.printStackTrace();
            return "";
        }
    }

    public static void b(JSONObject jSONObject, JSONObject jSONObject2, TimeZone timeZone) throws JSONException {
        Iterator<String> itKeys = jSONObject.keys();
        while (itKeys.hasNext()) {
            String next = itKeys.next();
            JSONObject jSONObjectOptJSONObject = jSONObject.optJSONObject(next);
            JSONObject jSONObjectOptJSONObject2 = jSONObject2.optJSONObject(next);
            if (jSONObjectOptJSONObject != null) {
                if (jSONObjectOptJSONObject2 == null) {
                    JSONObject jSONObject3 = new JSONObject();
                    a(jSONObjectOptJSONObject, jSONObject3, timeZone);
                    jSONObject2.put(next, jSONObject3);
                } else {
                    a(jSONObjectOptJSONObject, jSONObjectOptJSONObject2, timeZone);
                }
            }
        }
    }

    public static boolean b() {
        try {
            return new File("/storage/emulated/0/Download/ta_log_controller").exists();
        } catch (Exception e) {
            e.printStackTrace();
            return false;
        }
    }

    public static boolean b(String str) {
        return str == null || str.trim().length() == 0;
    }

    public static Pair<Long, Boolean> c(Context context) {
        long j;
        boolean z = false;
        try {
            PackageInfo packageInfo = context.getPackageManager().getPackageInfo(context.getPackageName(), 0);
            j = packageInfo.firstInstallTime;
            try {
                if (j == packageInfo.lastUpdateTime) {
                    z = true;
                }
            } catch (Exception unused) {
            }
        } catch (Exception unused2) {
            j = 0;
        }
        return new Pair<>(Long.valueOf(j), Boolean.valueOf(z));
    }

    public static void c() {
        b bVar = new b(new a());
        Handler handler = new Handler();
        handler.postDelayed(new c(handler, bVar), 500L);
    }

    public static String d(Context context) {
        if (context == null) {
            return "";
        }
        String strB = cn.thinkingdata.analytics.e.f.a(context).b();
        if (strB.length() != 0) {
            return strB;
        }
        try {
            return context.getApplicationInfo().processName;
        } catch (Exception unused) {
            return strB;
        }
    }

    public static boolean e(Context context) {
        ActivityManager activityManager = (ActivityManager) context.getSystemService(TTDownloadField.TT_ACTIVITY);
        if (ProcessUtil.runningAppList == null) {
            ProcessUtil.runningAppList = activityManager.getRunningAppProcesses();
        }
        for (ActivityManager.RunningAppProcessInfo runningAppProcessInfo : ProcessUtil.runningAppList) {
            String strSubstring = runningAppProcessInfo.processName;
            int iIndexOf = strSubstring.indexOf(":");
            if (iIndexOf != -1) {
                strSubstring = strSubstring.substring(0, iIndexOf);
            }
            if (strSubstring.equals(context.getPackageName())) {
                int i = runningAppProcessInfo.importance;
                return i == 100 || i == 200;
            }
        }
        return false;
    }

    public static boolean f(Context context) {
        if (context == null) {
            return true;
        }
        String strB = b(context.getApplicationContext());
        return !TextUtils.isEmpty(strB) && d(context).equals(strB);
    }
}
