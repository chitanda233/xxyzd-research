package cn.thinkingdata.analytics;

import android.app.Activity;
import android.app.Dialog;
import android.content.Context;
import android.text.TextUtils;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Adapter;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.CheckedTextView;
import android.widget.CompoundButton;
import android.widget.DatePicker;
import android.widget.ExpandableListAdapter;
import android.widget.ExpandableListView;
import android.widget.GridView;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.RatingBar;
import android.widget.SeekBar;
import android.widget.Spinner;
import android.widget.Switch;
import android.widget.TabHost;
import android.widget.TextView;
import android.widget.TimePicker;
import android.widget.ToggleButton;
import cn.thinkingdata.analytics.h.q;
import cn.thinkingdata.core.utils.TDLog;
import java.lang.reflect.Method;
import java.util.Iterator;
import java.util.List;
import java.util.Locale;
import java.util.TimeZone;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class ThinkingDataRuntimeBridge {
    private static final String TAG = "ThinkingAnalytics.ThinkingDataRuntimeBridge";

    class a implements ThinkingAnalyticsSDK.n {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ Object f60a;

        a(Object obj) {
            this.f60a = obj;
        }

        /* JADX WARN: Code duplicated, block: B:32:0x0090 A[Catch: JSONException -> 0x011d, TRY_ENTER, TryCatch #1 {JSONException -> 0x011d, blocks: (B:18:0x005a, B:21:0x006c, B:29:0x0089, B:32:0x0090, B:34:0x0098, B:36:0x009d, B:40:0x00bf, B:42:0x00c5, B:44:0x00d1, B:55:0x010d, B:45:0x00db, B:47:0x00e9, B:49:0x00f3, B:51:0x0101, B:56:0x0111, B:58:0x0117, B:37:0x00b4, B:39:0x00bc, B:25:0x0077, B:27:0x0081), top: B:64:0x005a }] */
        /* JADX WARN: Code duplicated, block: B:34:0x0098 A[Catch: JSONException -> 0x011d, TRY_LEAVE, TryCatch #1 {JSONException -> 0x011d, blocks: (B:18:0x005a, B:21:0x006c, B:29:0x0089, B:32:0x0090, B:34:0x0098, B:36:0x009d, B:40:0x00bf, B:42:0x00c5, B:44:0x00d1, B:55:0x010d, B:45:0x00db, B:47:0x00e9, B:49:0x00f3, B:51:0x0101, B:56:0x0111, B:58:0x0117, B:37:0x00b4, B:39:0x00bc, B:25:0x0077, B:27:0x0081), top: B:64:0x005a }] */
        /* JADX WARN: Code duplicated, block: B:37:0x00b4 A[Catch: JSONException -> 0x011d, TryCatch #1 {JSONException -> 0x011d, blocks: (B:18:0x005a, B:21:0x006c, B:29:0x0089, B:32:0x0090, B:34:0x0098, B:36:0x009d, B:40:0x00bf, B:42:0x00c5, B:44:0x00d1, B:55:0x010d, B:45:0x00db, B:47:0x00e9, B:49:0x00f3, B:51:0x0101, B:56:0x0111, B:58:0x0117, B:37:0x00b4, B:39:0x00bc, B:25:0x0077, B:27:0x0081), top: B:64:0x005a }] */
        /* JADX WARN: Code duplicated, block: B:39:0x00bc A[Catch: JSONException -> 0x011d, TryCatch #1 {JSONException -> 0x011d, blocks: (B:18:0x005a, B:21:0x006c, B:29:0x0089, B:32:0x0090, B:34:0x0098, B:36:0x009d, B:40:0x00bf, B:42:0x00c5, B:44:0x00d1, B:55:0x010d, B:45:0x00db, B:47:0x00e9, B:49:0x00f3, B:51:0x0101, B:56:0x0111, B:58:0x0117, B:37:0x00b4, B:39:0x00bc, B:25:0x0077, B:27:0x0081), top: B:64:0x005a }] */
        /* JADX WARN: Code duplicated, block: B:42:0x00c5 A[Catch: JSONException -> 0x011d, TryCatch #1 {JSONException -> 0x011d, blocks: (B:18:0x005a, B:21:0x006c, B:29:0x0089, B:32:0x0090, B:34:0x0098, B:36:0x009d, B:40:0x00bf, B:42:0x00c5, B:44:0x00d1, B:55:0x010d, B:45:0x00db, B:47:0x00e9, B:49:0x00f3, B:51:0x0101, B:56:0x0111, B:58:0x0117, B:37:0x00b4, B:39:0x00bc, B:25:0x0077, B:27:0x0081), top: B:64:0x005a }] */
        /* JADX WARN: Code duplicated, block: B:44:0x00d1 A[Catch: JSONException -> 0x011d, TryCatch #1 {JSONException -> 0x011d, blocks: (B:18:0x005a, B:21:0x006c, B:29:0x0089, B:32:0x0090, B:34:0x0098, B:36:0x009d, B:40:0x00bf, B:42:0x00c5, B:44:0x00d1, B:55:0x010d, B:45:0x00db, B:47:0x00e9, B:49:0x00f3, B:51:0x0101, B:56:0x0111, B:58:0x0117, B:37:0x00b4, B:39:0x00bc, B:25:0x0077, B:27:0x0081), top: B:64:0x005a }] */
        /* JADX WARN: Code duplicated, block: B:45:0x00db A[Catch: JSONException -> 0x011d, TryCatch #1 {JSONException -> 0x011d, blocks: (B:18:0x005a, B:21:0x006c, B:29:0x0089, B:32:0x0090, B:34:0x0098, B:36:0x009d, B:40:0x00bf, B:42:0x00c5, B:44:0x00d1, B:55:0x010d, B:45:0x00db, B:47:0x00e9, B:49:0x00f3, B:51:0x0101, B:56:0x0111, B:58:0x0117, B:37:0x00b4, B:39:0x00bc, B:25:0x0077, B:27:0x0081), top: B:64:0x005a }] */
        /* JADX WARN: Code duplicated, block: B:58:0x0117 A[Catch: JSONException -> 0x011d, TRY_LEAVE, TryCatch #1 {JSONException -> 0x011d, blocks: (B:18:0x005a, B:21:0x006c, B:29:0x0089, B:32:0x0090, B:34:0x0098, B:36:0x009d, B:40:0x00bf, B:42:0x00c5, B:44:0x00d1, B:55:0x010d, B:45:0x00db, B:47:0x00e9, B:49:0x00f3, B:51:0x0101, B:56:0x0111, B:58:0x0117, B:37:0x00b4, B:39:0x00bc, B:25:0x0077, B:27:0x0081), top: B:64:0x005a }] */
        /* JADX WARN: Code duplicated, block: B:67:? A[RETURN, SYNTHETIC] */
        @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK.n
        public void a(ThinkingAnalyticsSDK thinkingAnalyticsSDK) {
            Activity activity;
            Object obj;
            ThinkingDataAutoTrackAppViewScreenUrl thinkingDataAutoTrackAppViewScreenUrl;
            JSONObject trackProperties;
            if (thinkingAnalyticsSDK.isTrackFragmentAppViewScreenEnabled()) {
                ThinkingDataIgnoreTrackAppViewScreen thinkingDataIgnoreTrackAppViewScreen = (ThinkingDataIgnoreTrackAppViewScreen) this.f60a.getClass().getAnnotation(ThinkingDataIgnoreTrackAppViewScreen.class);
                if (thinkingDataIgnoreTrackAppViewScreen == null || !(TextUtils.isEmpty(thinkingDataIgnoreTrackAppViewScreen.appId()) || thinkingAnalyticsSDK.getToken().equals(thinkingDataIgnoreTrackAppViewScreen.appId()))) {
                    JSONObject jSONObject = new JSONObject();
                    String canonicalName = this.f60a.getClass().getCanonicalName();
                    try {
                        activity = (Activity) this.f60a.getClass().getMethod("getActivity", new Class[0]).invoke(this.f60a, new Object[0]);
                    } catch (Exception unused) {
                        activity = null;
                    }
                    try {
                        String strA = q.a(this.f60a, thinkingAnalyticsSDK.getToken());
                        if (TextUtils.isEmpty(strA) || TDPresetProperties.disableList.contains("#title")) {
                            if (activity != null) {
                                strA = q.a(activity);
                                if (!TextUtils.isEmpty(strA) && !TDPresetProperties.disableList.contains("#title")) {
                                }
                            }
                            if (activity != null) {
                                if (!TDPresetProperties.disableList.contains("#screen_name")) {
                                    jSONObject.put("#screen_name", String.format(Locale.CHINA, "%s|%s", activity.getClass().getCanonicalName(), canonicalName));
                                }
                            } else if (!TDPresetProperties.disableList.contains("#screen_name")) {
                                jSONObject.put("#screen_name", canonicalName);
                            }
                            obj = this.f60a;
                            if (!(obj instanceof ScreenAutoTracker)) {
                                ScreenAutoTracker screenAutoTracker = (ScreenAutoTracker) obj;
                                canonicalName = screenAutoTracker.getScreenUrl();
                                trackProperties = screenAutoTracker.getTrackProperties();
                                if (trackProperties != null) {
                                    q.a(trackProperties, jSONObject, thinkingAnalyticsSDK.mConfig.getDefaultTimeZone());
                                }
                            } else {
                                thinkingDataAutoTrackAppViewScreenUrl = (ThinkingDataAutoTrackAppViewScreenUrl) obj.getClass().getAnnotation(ThinkingDataAutoTrackAppViewScreenUrl.class);
                                if (thinkingDataAutoTrackAppViewScreenUrl != null || (!TextUtils.isEmpty(thinkingDataAutoTrackAppViewScreenUrl.appId()) && !thinkingAnalyticsSDK.getToken().equals(thinkingDataAutoTrackAppViewScreenUrl.appId()))) {
                                    if (thinkingAnalyticsSDK.isIgnoreAppViewInExtPackage()) {
                                        return;
                                    }
                                    thinkingAnalyticsSDK.autoTrack("ta_app_view", jSONObject);
                                    return;
                                } else {
                                    String strUrl = thinkingDataAutoTrackAppViewScreenUrl.url();
                                    if (!TextUtils.isEmpty(strUrl)) {
                                        canonicalName = strUrl;
                                    }
                                }
                            }
                            thinkingAnalyticsSDK.trackViewScreenInternal(canonicalName, jSONObject);
                        }
                        jSONObject.put("#title", strA);
                        if (activity != null) {
                            if (!TDPresetProperties.disableList.contains("#screen_name")) {
                                jSONObject.put("#screen_name", String.format(Locale.CHINA, "%s|%s", activity.getClass().getCanonicalName(), canonicalName));
                            }
                        } else if (!TDPresetProperties.disableList.contains("#screen_name")) {
                            jSONObject.put("#screen_name", canonicalName);
                        }
                        obj = this.f60a;
                        if (!(obj instanceof ScreenAutoTracker)) {
                            thinkingDataAutoTrackAppViewScreenUrl = (ThinkingDataAutoTrackAppViewScreenUrl) obj.getClass().getAnnotation(ThinkingDataAutoTrackAppViewScreenUrl.class);
                            if (thinkingDataAutoTrackAppViewScreenUrl != null) {
                            }
                            if (thinkingAnalyticsSDK.isIgnoreAppViewInExtPackage()) {
                                thinkingAnalyticsSDK.autoTrack("ta_app_view", jSONObject);
                                return;
                            }
                            return;
                        }
                        ScreenAutoTracker screenAutoTracker2 = (ScreenAutoTracker) obj;
                        canonicalName = screenAutoTracker2.getScreenUrl();
                        trackProperties = screenAutoTracker2.getTrackProperties();
                        if (trackProperties != null) {
                            q.a(trackProperties, jSONObject, thinkingAnalyticsSDK.mConfig.getDefaultTimeZone());
                        }
                        thinkingAnalyticsSDK.trackViewScreenInternal(canonicalName, jSONObject);
                    } catch (JSONException unused2) {
                        TDLog.d(ThinkingDataRuntimeBridge.TAG, "JSONException occurred when track fragment events");
                    }
                }
            }
        }
    }

    class b implements ThinkingAnalyticsSDK.n {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ String f61a;
        final /* synthetic */ String b;
        final /* synthetic */ JSONObject c;

        b(String str, String str2, JSONObject jSONObject) {
            this.f61a = str;
            this.b = str2;
            this.c = jSONObject;
        }

        @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK.n
        public void a(ThinkingAnalyticsSDK thinkingAnalyticsSDK) {
            if (thinkingAnalyticsSDK.isAutoTrackEnabled()) {
                if (TextUtils.isEmpty(this.f61a) || thinkingAnalyticsSDK.getToken().equals(this.f61a)) {
                    thinkingAnalyticsSDK.track(this.b, this.c);
                }
            }
        }
    }

    class c implements ThinkingAnalyticsSDK.n {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ String f62a;
        final /* synthetic */ String b;
        final /* synthetic */ JSONObject c;

        c(String str, String str2, JSONObject jSONObject) {
            this.f62a = str;
            this.b = str2;
            this.c = jSONObject;
        }

        @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK.n
        public void a(ThinkingAnalyticsSDK thinkingAnalyticsSDK) {
            if (thinkingAnalyticsSDK.isAutoTrackEnabled()) {
                if (TextUtils.isEmpty(this.f62a) || thinkingAnalyticsSDK.getToken().equals(this.f62a)) {
                    thinkingAnalyticsSDK.track(this.b, this.c);
                }
            }
        }
    }

    class d implements ThinkingAnalyticsSDK.n {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ Object f63a;
        final /* synthetic */ View b;

        d(Object obj, View view) {
            this.f63a = obj;
            this.b = view;
        }

        /* JADX WARN: Code duplicated, block: B:231:0x0432 A[Catch: Exception -> 0x0459, TryCatch #5 {Exception -> 0x0459, blocks: (B:3:0x0016, B:6:0x001d, B:9:0x0026, B:11:0x002a, B:13:0x002e, B:15:0x003a, B:18:0x0049, B:20:0x004d, B:22:0x0059, B:25:0x0068, B:27:0x006c, B:29:0x0074, B:31:0x007b, B:33:0x0087, B:35:0x008d, B:38:0x0098, B:40:0x00a0, B:42:0x00a6, B:45:0x00b1, B:53:0x00df, B:55:0x00fa, B:58:0x0105, B:61:0x010e, B:63:0x0128, B:65:0x0130, B:67:0x0135, B:69:0x013d, B:71:0x0152, B:73:0x015a, B:85:0x0176, B:87:0x0186, B:224:0x0415, B:226:0x041b, B:228:0x0423, B:229:0x042a, B:231:0x0432, B:232:0x0435, B:234:0x044a, B:235:0x0453, B:92:0x0195, B:94:0x019b, B:96:0x01a5, B:98:0x01ad, B:102:0x01c2, B:99:0x01b4, B:101:0x01bc, B:106:0x01d4, B:127:0x024f, B:128:0x0254, B:130:0x025a, B:132:0x0262, B:134:0x026b, B:136:0x0271, B:133:0x0267, B:138:0x027a, B:140:0x027e, B:151:0x02a7, B:153:0x02ab, B:155:0x02b5, B:157:0x02b9, B:160:0x02c3, B:161:0x02c9, B:162:0x02cf, B:164:0x02d3, B:166:0x02dd, B:168:0x02e1, B:170:0x02eb, B:172:0x02ef, B:174:0x02f9, B:176:0x02fd, B:179:0x030b, B:186:0x0326, B:180:0x0310, B:182:0x0314, B:185:0x0322, B:187:0x032c, B:189:0x0330, B:191:0x033e, B:193:0x0342, B:195:0x0350, B:207:0x038f, B:209:0x0393, B:215:0x03e6, B:211:0x03b9, B:213:0x03bd, B:216:0x03ec, B:52:0x00dc, B:47:0x00c9, B:49:0x00d5), top: B:252:0x0016, inners: #3 }] */
        /* JADX WARN: Code duplicated, block: B:234:0x044a A[Catch: Exception -> 0x0459, TryCatch #5 {Exception -> 0x0459, blocks: (B:3:0x0016, B:6:0x001d, B:9:0x0026, B:11:0x002a, B:13:0x002e, B:15:0x003a, B:18:0x0049, B:20:0x004d, B:22:0x0059, B:25:0x0068, B:27:0x006c, B:29:0x0074, B:31:0x007b, B:33:0x0087, B:35:0x008d, B:38:0x0098, B:40:0x00a0, B:42:0x00a6, B:45:0x00b1, B:53:0x00df, B:55:0x00fa, B:58:0x0105, B:61:0x010e, B:63:0x0128, B:65:0x0130, B:67:0x0135, B:69:0x013d, B:71:0x0152, B:73:0x015a, B:85:0x0176, B:87:0x0186, B:224:0x0415, B:226:0x041b, B:228:0x0423, B:229:0x042a, B:231:0x0432, B:232:0x0435, B:234:0x044a, B:235:0x0453, B:92:0x0195, B:94:0x019b, B:96:0x01a5, B:98:0x01ad, B:102:0x01c2, B:99:0x01b4, B:101:0x01bc, B:106:0x01d4, B:127:0x024f, B:128:0x0254, B:130:0x025a, B:132:0x0262, B:134:0x026b, B:136:0x0271, B:133:0x0267, B:138:0x027a, B:140:0x027e, B:151:0x02a7, B:153:0x02ab, B:155:0x02b5, B:157:0x02b9, B:160:0x02c3, B:161:0x02c9, B:162:0x02cf, B:164:0x02d3, B:166:0x02dd, B:168:0x02e1, B:170:0x02eb, B:172:0x02ef, B:174:0x02f9, B:176:0x02fd, B:179:0x030b, B:186:0x0326, B:180:0x0310, B:182:0x0314, B:185:0x0322, B:187:0x032c, B:189:0x0330, B:191:0x033e, B:193:0x0342, B:195:0x0350, B:207:0x038f, B:209:0x0393, B:215:0x03e6, B:211:0x03b9, B:213:0x03bd, B:216:0x03ec, B:52:0x00dc, B:47:0x00c9, B:49:0x00d5), top: B:252:0x0016, inners: #3 }] */
        @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK.n
        public void a(ThinkingAnalyticsSDK thinkingAnalyticsSDK) {
            Class<?> cls;
            Class<?> cls2;
            String strSubstring;
            StringBuilder sbAppend;
            Object obj;
            CharSequence string;
            CharSequence contentDescription;
            JSONObject jSONObject;
            try {
                if (thinkingAnalyticsSDK.isAutoTrackEnabled() && !thinkingAnalyticsSDK.isAutoTrackEventTypeIgnored(ThinkingAnalyticsSDK.AutoTrackEventType.APP_CLICK)) {
                    Object obj2 = this.f63a;
                    if (obj2 != null) {
                        if (obj2 instanceof ThinkingDataIgnoreTrackOnClick) {
                            ThinkingDataIgnoreTrackOnClick thinkingDataIgnoreTrackOnClick = (ThinkingDataIgnoreTrackOnClick) obj2;
                            if (TextUtils.isEmpty(thinkingDataIgnoreTrackOnClick.appId()) || thinkingAnalyticsSDK.getToken().equals(thinkingDataIgnoreTrackOnClick.appId())) {
                                return;
                            }
                        } else if (obj2 instanceof ThinkingDataTrackViewOnClick) {
                            ThinkingDataTrackViewOnClick thinkingDataTrackViewOnClick = (ThinkingDataTrackViewOnClick) obj2;
                            if (!TextUtils.isEmpty(thinkingDataTrackViewOnClick.appId()) && !thinkingAnalyticsSDK.getToken().equals(thinkingDataTrackViewOnClick.appId())) {
                                return;
                            }
                        } else if (obj2 instanceof String) {
                            String str = (String) obj2;
                            if (!TextUtils.isEmpty(str) && str.length() >= 2) {
                                String strSubstring2 = str.substring(2);
                                if (str.startsWith("1_")) {
                                    if (TextUtils.isEmpty(strSubstring2) || thinkingAnalyticsSDK.getToken().equals(strSubstring2)) {
                                        return;
                                    }
                                } else if (str.startsWith("2_") && !TextUtils.isEmpty(strSubstring2) && !thinkingAnalyticsSDK.getToken().equals(strSubstring2)) {
                                    return;
                                }
                            }
                        }
                    }
                    long jCurrentTimeMillis = System.currentTimeMillis();
                    String str2 = (String) q.a(thinkingAnalyticsSDK.getToken(), this.b, R.id.thinking_analytics_tag_view_onclick_timestamp);
                    if (!TextUtils.isEmpty(str2)) {
                        try {
                            if (jCurrentTimeMillis - Long.parseLong(str2) < 500) {
                                TDLog.i(ThinkingDataRuntimeBridge.TAG, "This onClick maybe extends from super, IGNORE");
                                return;
                            }
                        } catch (Exception e) {
                            e.printStackTrace();
                        }
                        TDLog.e(ThinkingDataRuntimeBridge.TAG, "onViewClickMethod error: " + e.toString());
                        e.printStackTrace();
                    }
                    q.a(thinkingAnalyticsSDK.getToken(), this.b, R.id.thinking_analytics_tag_view_onclick_timestamp, String.valueOf(jCurrentTimeMillis));
                    Activity activityA = q.a(this.b.getContext());
                    if ((activityA == null || !thinkingAnalyticsSDK.isActivityAutoTrackAppClickIgnored(activityA.getClass())) && !ThinkingDataRuntimeBridge.isViewIgnored(thinkingAnalyticsSDK, this.b)) {
                        JSONObject jSONObject2 = new JSONObject();
                        q.a(activityA, this.b, jSONObject2);
                        String strA = q.a(this.b, thinkingAnalyticsSDK.getToken());
                        if (!TextUtils.isEmpty(strA) && !TDPresetProperties.disableList.contains("#element_id")) {
                            jSONObject2.put("#element_id", strA);
                        }
                        if (activityA != null && !TDPresetProperties.disableList.contains("#screen_name")) {
                            jSONObject2.put("#screen_name", activityA.getClass().getCanonicalName());
                            String strA2 = q.a(activityA);
                            if (!TextUtils.isEmpty(strA2) && !TDPresetProperties.disableList.contains("#title")) {
                                jSONObject2.put("#title", strA2);
                            }
                        }
                        CharSequence charSequenceA = null;
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
                        try {
                            cls2 = Class.forName("androidx.viewpager.widget.ViewPager");
                        } catch (Exception unused3) {
                            cls2 = null;
                        }
                        if (cls2 == null) {
                            try {
                                cls2 = Class.forName("androidx.viewpager.widget.ViewPager");
                            } catch (Exception unused4) {
                            }
                        }
                        Object canonicalName = this.b.getClass().getCanonicalName();
                        View view = this.b;
                        if (view instanceof CheckBox) {
                            string = ((CheckBox) view).getText();
                            obj = "CheckBox";
                        } else {
                            if (cls == null || !cls.isInstance(view)) {
                                if (cls2 == null || !cls2.isInstance(this.b)) {
                                    View view2 = this.b;
                                    if (view2 instanceof Switch) {
                                        Switch r9 = (Switch) view2;
                                        CharSequence textOn = r9.isChecked() ? r9.getTextOn() : r9.getTextOff();
                                        if (TextUtils.isEmpty(textOn)) {
                                            textOn = r9.getText();
                                        }
                                        charSequenceA = textOn;
                                        canonicalName = "SwitchButton";
                                    } else if (view2 instanceof RadioGroup) {
                                        int checkedRadioButtonId = ((RadioGroup) view2).getCheckedRadioButtonId();
                                        canonicalName = "RadioGroup";
                                        if (activityA != null) {
                                            try {
                                                RadioButton radioButton = (RadioButton) activityA.findViewById(checkedRadioButtonId);
                                                if (radioButton != null && !TextUtils.isEmpty(radioButton.getText())) {
                                                    strSubstring = radioButton.getText().toString();
                                                    charSequenceA = strSubstring;
                                                }
                                            } catch (Exception e2) {
                                                e = e2;
                                                e.printStackTrace();
                                            }
                                        }
                                    } else if (view2 instanceof RadioButton) {
                                        string = ((RadioButton) view2).getText();
                                        obj = "RadioButton";
                                    } else if (view2 instanceof ToggleButton) {
                                        ToggleButton toggleButton = (ToggleButton) view2;
                                        obj = "ToggleButton";
                                        string = toggleButton.isChecked() ? toggleButton.getTextOn() : toggleButton.getTextOff();
                                    } else if (view2 instanceof Button) {
                                        string = ((Button) view2).getText();
                                        obj = "Button";
                                    } else if (view2 instanceof CheckedTextView) {
                                        string = ((CheckedTextView) view2).getText();
                                        obj = "CheckedTextView";
                                    } else if (view2 instanceof TextView) {
                                        string = ((TextView) view2).getText();
                                        obj = "TextView";
                                    } else if (view2 instanceof ImageButton) {
                                        ImageButton imageButton = (ImageButton) view2;
                                        canonicalName = "ImageButton";
                                        if (!TextUtils.isEmpty(imageButton.getContentDescription())) {
                                            contentDescription = imageButton.getContentDescription();
                                            strSubstring = contentDescription.toString();
                                            charSequenceA = strSubstring;
                                        }
                                    } else if (view2 instanceof ImageView) {
                                        ImageView imageView = (ImageView) view2;
                                        canonicalName = "ImageView";
                                        if (!TextUtils.isEmpty(imageView.getContentDescription())) {
                                            contentDescription = imageView.getContentDescription();
                                            strSubstring = contentDescription.toString();
                                            charSequenceA = strSubstring;
                                        }
                                    } else if (view2 instanceof RatingBar) {
                                        string = String.valueOf(((RatingBar) view2).getRating());
                                        obj = "RatingBar";
                                    } else if (view2 instanceof SeekBar) {
                                        string = String.valueOf(((SeekBar) view2).getProgress());
                                        obj = "SeekBar";
                                    } else if (view2 instanceof Spinner) {
                                        canonicalName = "Spinner";
                                        try {
                                            charSequenceA = q.a(new StringBuilder(), (ViewGroup) this.b);
                                            if (!TextUtils.isEmpty(charSequenceA)) {
                                                charSequenceA = charSequenceA.toString().substring(0, charSequenceA.length() - 1);
                                            }
                                            if (!TDPresetProperties.disableList.contains("#element_position")) {
                                                jSONObject2.put("#element_position", ((Spinner) this.b).getSelectedItemPosition());
                                            }
                                        } catch (Exception e3) {
                                            e = e3;
                                            e.printStackTrace();
                                        }
                                    } else {
                                        if (view2 instanceof TimePicker) {
                                            sbAppend = new StringBuilder().append(((TimePicker) this.b).getCurrentHour()).append(":").append(((TimePicker) this.b).getCurrentMinute());
                                            obj = "TimePicker";
                                        } else if (view2 instanceof DatePicker) {
                                            DatePicker datePicker = (DatePicker) view2;
                                            sbAppend = new StringBuilder().append(datePicker.getYear()).append("-").append(datePicker.getMonth()).append("-").append(datePicker.getDayOfMonth());
                                            obj = "DatePicker";
                                        } else if (view2 instanceof ViewGroup) {
                                            try {
                                                charSequenceA = q.a(new StringBuilder(), (ViewGroup) this.b);
                                                if (!TextUtils.isEmpty(charSequenceA)) {
                                                    strSubstring = charSequenceA.toString().substring(0, charSequenceA.length() - 1);
                                                    charSequenceA = strSubstring;
                                                }
                                            } catch (Exception e4) {
                                                e = e4;
                                                e.printStackTrace();
                                            }
                                        }
                                        string = sbAppend.toString();
                                    }
                                } else {
                                    canonicalName = "ViewPager";
                                    try {
                                        Object objInvoke = this.b.getClass().getMethod("getAdapter", new Class[0]).invoke(this.b, new Object[0]);
                                        Method method = this.b.getClass().getMethod("getCurrentItem", new Class[0]);
                                        if (method != null) {
                                            int iIntValue = ((Integer) method.invoke(this.b, new Object[0])).intValue();
                                            if (!TDPresetProperties.disableList.contains("#element_position")) {
                                                jSONObject2.put("#element_position", String.format(Locale.CHINA, "%d", Integer.valueOf(iIntValue)));
                                            }
                                            Method method2 = objInvoke.getClass().getMethod("getPageTitle", Integer.TYPE);
                                            if (method2 != null) {
                                                strSubstring = (String) method2.invoke(objInvoke, Integer.valueOf(iIntValue));
                                                charSequenceA = strSubstring;
                                            }
                                        }
                                    } catch (Exception e5) {
                                        e = e5;
                                        e.printStackTrace();
                                    }
                                }
                                if (!TextUtils.isEmpty(charSequenceA) && !TDPresetProperties.disableList.contains("#element_content")) {
                                    jSONObject2.put("#element_content", charSequenceA.toString());
                                }
                                if (!TDPresetProperties.disableList.contains("#element_type")) {
                                    jSONObject2.put("#element_type", canonicalName);
                                }
                                q.a(this.b, jSONObject2);
                                jSONObject = (JSONObject) q.a(thinkingAnalyticsSDK.getToken(), this.b, R.id.thinking_analytics_tag_view_properties);
                                if (jSONObject != null) {
                                    q.a(jSONObject, jSONObject2, thinkingAnalyticsSDK.mConfig.getDefaultTimeZone());
                                }
                                thinkingAnalyticsSDK.autoTrack("ta_app_click", jSONObject2);
                            }
                            string = (String) (((CompoundButton) this.b).isChecked() ? this.b.getClass().getMethod("getTextOn", new Class[0]) : this.b.getClass().getMethod("getTextOff", new Class[0])).invoke(this.b, new Object[0]);
                            obj = "SwitchCompat";
                        }
                        charSequenceA = string;
                        canonicalName = obj;
                        if (!TextUtils.isEmpty(charSequenceA)) {
                            jSONObject2.put("#element_content", charSequenceA.toString());
                        }
                        if (!TDPresetProperties.disableList.contains("#element_type")) {
                            jSONObject2.put("#element_type", canonicalName);
                        }
                        q.a(this.b, jSONObject2);
                        jSONObject = (JSONObject) q.a(thinkingAnalyticsSDK.getToken(), this.b, R.id.thinking_analytics_tag_view_properties);
                        if (jSONObject != null) {
                            q.a(jSONObject, jSONObject2, thinkingAnalyticsSDK.mConfig.getDefaultTimeZone());
                        }
                        thinkingAnalyticsSDK.autoTrack("ta_app_click", jSONObject2);
                    }
                }
            } catch (Exception e6) {
                TDLog.e(ThinkingDataRuntimeBridge.TAG, "onViewClickMethod error: " + e6.toString());
                e6.printStackTrace();
            }
        }
    }

    class e implements ThinkingAnalyticsSDK.n {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ Context f64a;
        final /* synthetic */ View b;
        final /* synthetic */ View c;
        final /* synthetic */ int d;
        final /* synthetic */ int e;

        e(Context context, View view, View view2, int i, int i2) {
            this.f64a = context;
            this.b = view;
            this.c = view2;
            this.d = i;
            this.e = i2;
        }

        @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK.n
        public void a(ThinkingAnalyticsSDK thinkingAnalyticsSDK) {
            Object obj;
            String strSubstring;
            try {
                if (thinkingAnalyticsSDK.isAutoTrackEnabled() && !thinkingAnalyticsSDK.isAutoTrackEventTypeIgnored(ThinkingAnalyticsSDK.AutoTrackEventType.APP_CLICK)) {
                    Activity activityA = q.a(this.f64a);
                    if ((activityA != null && thinkingAnalyticsSDK.isActivityAutoTrackAppClickIgnored(activityA.getClass())) || ThinkingDataRuntimeBridge.isViewIgnored(thinkingAnalyticsSDK, ExpandableListView.class) || ThinkingDataRuntimeBridge.isViewIgnored(thinkingAnalyticsSDK, this.b) || ThinkingDataRuntimeBridge.isViewIgnored(thinkingAnalyticsSDK, this.c)) {
                        return;
                    }
                    JSONObject jSONObject = new JSONObject();
                    q.a(activityA, this.c, jSONObject);
                    if (activityA != null && !TDPresetProperties.disableList.contains("#screen_name")) {
                        jSONObject.put("#screen_name", activityA.getClass().getCanonicalName());
                        String strA = q.a(activityA);
                        if (!TextUtils.isEmpty(strA) && !TDPresetProperties.disableList.contains("#title")) {
                            jSONObject.put("#title", strA);
                        }
                    }
                    String strA2 = q.a(this.b);
                    if (!TextUtils.isEmpty(strA2) && !TDPresetProperties.disableList.contains("#element_id")) {
                        jSONObject.put("#element_id", strA2);
                    }
                    if (this.d < 0) {
                        if (!TDPresetProperties.disableList.contains("#element_position")) {
                            obj = String.format(Locale.CHINA, "%d", Integer.valueOf(this.e));
                            jSONObject.put("#element_position", obj);
                        }
                        e.printStackTrace();
                        TDLog.i(ThinkingDataRuntimeBridge.TAG, " ExpandableListView.OnChildClickListener.onGroupClick AOP ERROR: " + e.getMessage());
                    }
                    if (!TDPresetProperties.disableList.contains("#element_position")) {
                        obj = String.format(Locale.CHINA, "%d:%d", Integer.valueOf(this.e), Integer.valueOf(this.d));
                        jSONObject.put("#element_position", obj);
                    }
                    e.printStackTrace();
                    TDLog.i(ThinkingDataRuntimeBridge.TAG, " ExpandableListView.OnChildClickListener.onGroupClick AOP ERROR: " + e.getMessage());
                    if (!TDPresetProperties.disableList.contains("#element_type")) {
                        jSONObject.put("#element_type", "ExpandableListView");
                    }
                    View view = this.c;
                    String strA3 = null;
                    if (!(view instanceof ViewGroup)) {
                        if (view instanceof TextView) {
                            strSubstring = (String) ((TextView) view).getText();
                            strA3 = strSubstring;
                        }
                        e.printStackTrace();
                        TDLog.i(ThinkingDataRuntimeBridge.TAG, " ExpandableListView.OnChildClickListener.onGroupClick AOP ERROR: " + e.getMessage());
                    }
                    try {
                        strA3 = q.a(new StringBuilder(), (ViewGroup) this.c);
                        if (!TextUtils.isEmpty(strA3)) {
                            strSubstring = strA3.substring(0, strA3.length() - 1);
                            strA3 = strSubstring;
                        }
                    } catch (Exception e) {
                        e.printStackTrace();
                    }
                    e.printStackTrace();
                    TDLog.i(ThinkingDataRuntimeBridge.TAG, " ExpandableListView.OnChildClickListener.onGroupClick AOP ERROR: " + e.getMessage());
                    if (!TextUtils.isEmpty(strA3) && !TDPresetProperties.disableList.contains("#element_content")) {
                        jSONObject.put("#element_content", strA3);
                    }
                    q.a(this.b, jSONObject);
                    JSONObject jSONObject2 = (JSONObject) q.a(thinkingAnalyticsSDK.getToken(), this.c, R.id.thinking_analytics_tag_view_properties);
                    if (jSONObject2 != null) {
                        q.a(jSONObject2, jSONObject, thinkingAnalyticsSDK.mConfig.getDefaultTimeZone());
                    }
                    ExpandableListAdapter expandableListAdapter = ((ExpandableListView) this.b).getExpandableListAdapter();
                    if (expandableListAdapter != null && (expandableListAdapter instanceof ThinkingExpandableListViewItemTrackProperties)) {
                        try {
                            ThinkingExpandableListViewItemTrackProperties thinkingExpandableListViewItemTrackProperties = (ThinkingExpandableListViewItemTrackProperties) expandableListAdapter;
                            int i = this.d;
                            JSONObject thinkingGroupItemTrackProperties = i < 0 ? thinkingExpandableListViewItemTrackProperties.getThinkingGroupItemTrackProperties(this.e) : thinkingExpandableListViewItemTrackProperties.getThinkingChildItemTrackProperties(this.e, i);
                            if (thinkingGroupItemTrackProperties != null && cn.thinkingdata.analytics.h.g.a(thinkingGroupItemTrackProperties)) {
                                q.a(thinkingGroupItemTrackProperties, jSONObject, thinkingAnalyticsSDK.mConfig.getDefaultTimeZone());
                            }
                        } catch (JSONException e2) {
                            e2.printStackTrace();
                        }
                    }
                    thinkingAnalyticsSDK.autoTrack("ta_app_click", jSONObject);
                }
            } catch (Exception e3) {
                e3.printStackTrace();
                TDLog.i(ThinkingDataRuntimeBridge.TAG, " ExpandableListView.OnChildClickListener.onGroupClick AOP ERROR: " + e3.getMessage());
            }
        }
    }

    class f implements ThinkingAnalyticsSDK.n {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ Dialog f65a;
        final /* synthetic */ int b;

        f(Dialog dialog, int i) {
            this.f65a = dialog;
            this.b = i;
        }

        /* JADX WARN: Code restructure failed: missing block: B:55:0x00e3, code lost:
        
            if (cn.thinkingdata.analytics.TDPresetProperties.disableList.contains("#element_content") == false) goto L56;
         */
        /* JADX WARN: Code restructure failed: missing block: B:56:0x00e5, code lost:
        
            r0 = r0.getText();
         */
        /* JADX WARN: Code restructure failed: missing block: B:78:0x014e, code lost:
        
            if (cn.thinkingdata.analytics.TDPresetProperties.disableList.contains("#element_content") == false) goto L56;
         */
        @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK.n
        /*
            Code decompiled incorrectly, please refer to instructions dump.
            To view partially-correct add '--show-bad-code' argument
        */
        public void a(cn.thinkingdata.analytics.ThinkingAnalyticsSDK r10) {
            /*
                Method dump skipped, instruction units count: 425
                To view this dump add '--comments-level debug' option
            */
            throw new UnsupportedOperationException("Method not decompiled: cn.thinkingdata.analytics.ThinkingDataRuntimeBridge.f.a(cn.thinkingdata.analytics.ThinkingAnalyticsSDK):void");
        }
    }

    class g implements ThinkingAnalyticsSDK.n {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ View f66a;
        final /* synthetic */ View b;
        final /* synthetic */ int c;

        g(View view, View view2, int i) {
            this.f66a = view;
            this.b = view2;
            this.c = i;
        }

        @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK.n
        public void a(ThinkingAnalyticsSDK thinkingAnalyticsSDK) {
            Context context;
            String strSubstring;
            try {
                if (!thinkingAnalyticsSDK.isAutoTrackEnabled() || thinkingAnalyticsSDK.isAutoTrackEventTypeIgnored(ThinkingAnalyticsSDK.AutoTrackEventType.APP_CLICK) || (context = this.f66a.getContext()) == null) {
                    return;
                }
                Activity activityA = q.a(context);
                if ((activityA == null || !thinkingAnalyticsSDK.isActivityAutoTrackAppClickIgnored(activityA.getClass())) && !ThinkingDataRuntimeBridge.isViewIgnored(thinkingAnalyticsSDK, this.b.getClass())) {
                    JSONObject jSONObject = new JSONObject();
                    if (thinkingAnalyticsSDK.getIgnoredViewTypeList() != null) {
                        if ((this.b instanceof ListView) && !TDPresetProperties.disableList.contains("#element_type")) {
                            jSONObject.put("#element_type", "ListView");
                            if (ThinkingDataRuntimeBridge.isViewIgnored(thinkingAnalyticsSDK, ListView.class)) {
                                return;
                            }
                        } else if ((this.b instanceof GridView) && !TDPresetProperties.disableList.contains("#element_type")) {
                            jSONObject.put("#element_type", "GridView");
                            if (ThinkingDataRuntimeBridge.isViewIgnored(thinkingAnalyticsSDK, GridView.class)) {
                                return;
                            }
                        } else if ((this.b instanceof Spinner) && !TDPresetProperties.disableList.contains("#element_type")) {
                            jSONObject.put("#element_type", "Spinner");
                            if (ThinkingDataRuntimeBridge.isViewIgnored(thinkingAnalyticsSDK, Spinner.class)) {
                                return;
                            }
                        }
                    }
                    Adapter adapter = ((AdapterView) this.b).getAdapter();
                    if (adapter instanceof ThinkingAdapterViewItemTrackProperties) {
                        try {
                            JSONObject thinkingItemTrackProperties = ((ThinkingAdapterViewItemTrackProperties) adapter).getThinkingItemTrackProperties(this.c);
                            if (thinkingItemTrackProperties != null && cn.thinkingdata.analytics.h.g.a(thinkingItemTrackProperties)) {
                                q.a(thinkingItemTrackProperties, jSONObject, thinkingAnalyticsSDK.mConfig.getDefaultTimeZone());
                            }
                        } catch (JSONException e) {
                            e.printStackTrace();
                        }
                    }
                    q.a(activityA, this.f66a, jSONObject);
                    String strA = q.a(this.b, thinkingAnalyticsSDK.getToken());
                    if (!TextUtils.isEmpty(strA) && !TDPresetProperties.disableList.contains("#element_id")) {
                        jSONObject.put("#element_id", strA);
                    }
                    if (activityA != null && !TDPresetProperties.disableList.contains("#screen_name")) {
                        jSONObject.put("#screen_name", activityA.getClass().getCanonicalName());
                        String strA2 = q.a(activityA);
                        if (!TextUtils.isEmpty(strA2) && !TDPresetProperties.disableList.contains("#title")) {
                            jSONObject.put("#title", strA2);
                        }
                    }
                    if (!TDPresetProperties.disableList.contains("#element_position")) {
                        jSONObject.put("#element_position", String.valueOf(this.c));
                    }
                    View view = this.f66a;
                    String strA3 = null;
                    if (view instanceof ViewGroup) {
                        try {
                            strA3 = q.a(new StringBuilder(), (ViewGroup) this.f66a);
                            if (!TextUtils.isEmpty(strA3)) {
                                strSubstring = strA3.substring(0, strA3.length() - 1);
                                strA3 = strSubstring;
                            }
                        } catch (Exception e2) {
                            e2.printStackTrace();
                        }
                        e.printStackTrace();
                        TDLog.i(ThinkingDataRuntimeBridge.TAG, " AdapterView.OnItemClickListener.onItemClick AOP ERROR: " + e.getMessage());
                    }
                    if (view instanceof TextView) {
                        strSubstring = ((TextView) view).getText().toString();
                        strA3 = strSubstring;
                    }
                    if (!TextUtils.isEmpty(strA3) && !TDPresetProperties.disableList.contains("#element_content")) {
                        jSONObject.put("#element_content", strA3);
                    }
                    q.a(this.b, jSONObject);
                    JSONObject jSONObject2 = (JSONObject) q.a(thinkingAnalyticsSDK.getToken(), this.f66a, R.id.thinking_analytics_tag_view_properties);
                    if (jSONObject2 != null) {
                        q.a(jSONObject2, jSONObject, thinkingAnalyticsSDK.mConfig.getDefaultTimeZone());
                    }
                    thinkingAnalyticsSDK.autoTrack("ta_app_click", jSONObject);
                }
            } catch (Exception e3) {
                e3.printStackTrace();
                TDLog.i(ThinkingDataRuntimeBridge.TAG, " AdapterView.OnItemClickListener.onItemClick AOP ERROR: " + e3.getMessage());
            }
        }
    }

    class h implements ThinkingAnalyticsSDK.n {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ Object f67a;
        final /* synthetic */ MenuItem b;

        h(Object obj, MenuItem menuItem) {
            this.f67a = obj;
            this.b = menuItem;
        }

        @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK.n
        public void a(ThinkingAnalyticsSDK thinkingAnalyticsSDK) {
            Object obj;
            try {
                if (!thinkingAnalyticsSDK.isAutoTrackEnabled() || thinkingAnalyticsSDK.isAutoTrackEventTypeIgnored(ThinkingAnalyticsSDK.AutoTrackEventType.APP_CLICK) || ThinkingDataRuntimeBridge.isViewIgnored(thinkingAnalyticsSDK, MenuItem.class) || (obj = this.f67a) == null) {
                    return;
                }
                String resourceEntryName = null;
                Context context = obj instanceof Context ? (Context) obj : null;
                if (context == null) {
                    return;
                }
                Activity activityA = q.a(context);
                if (activityA == null || !thinkingAnalyticsSDK.isActivityAutoTrackAppClickIgnored(activityA.getClass())) {
                    try {
                        resourceEntryName = context.getResources().getResourceEntryName(this.b.getItemId());
                    } catch (Exception e) {
                        e.printStackTrace();
                    }
                    JSONObject jSONObject = new JSONObject();
                    if (activityA != null && !TDPresetProperties.disableList.contains("#screen_name")) {
                        jSONObject.put("#screen_name", activityA.getClass().getCanonicalName());
                        String strA = q.a(activityA);
                        if (!TextUtils.isEmpty(strA) && !TDPresetProperties.disableList.contains("#title")) {
                            jSONObject.put("#title", strA);
                        }
                    }
                    if (!TextUtils.isEmpty(resourceEntryName) && !TDPresetProperties.disableList.contains("#element_id")) {
                        jSONObject.put("#element_id", resourceEntryName);
                    }
                    if (!TextUtils.isEmpty(this.b.getTitle()) && !TDPresetProperties.disableList.contains("#element_content")) {
                        jSONObject.put("#element_content", this.b.getTitle());
                    }
                    if (!TDPresetProperties.disableList.contains("#element_type")) {
                        jSONObject.put("#element_type", "MenuItem");
                    }
                    thinkingAnalyticsSDK.autoTrack("ta_app_click", jSONObject);
                }
            } catch (Exception e2) {
                e2.printStackTrace();
                TDLog.i(ThinkingDataRuntimeBridge.TAG, "track MenuItem click error: " + e2.getMessage());
            }
        }
    }

    class i implements ThinkingAnalyticsSDK.n {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ String f68a;

        i(String str) {
            this.f68a = str;
        }

        @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK.n
        public void a(ThinkingAnalyticsSDK thinkingAnalyticsSDK) {
            try {
                if (!thinkingAnalyticsSDK.isAutoTrackEnabled() || thinkingAnalyticsSDK.isAutoTrackEventTypeIgnored(ThinkingAnalyticsSDK.AutoTrackEventType.APP_CLICK) || ThinkingDataRuntimeBridge.isViewIgnored(thinkingAnalyticsSDK, TabHost.class)) {
                    return;
                }
                JSONObject jSONObject = new JSONObject();
                if (!TDPresetProperties.disableList.contains("#element_content")) {
                    jSONObject.put("#element_content", this.f68a);
                }
                if (!TDPresetProperties.disableList.contains("#element_type")) {
                    jSONObject.put("#element_type", "TabHost");
                }
                thinkingAnalyticsSDK.autoTrack("ta_app_click", jSONObject);
            } catch (Exception e) {
                e.printStackTrace();
                TDLog.i(ThinkingDataRuntimeBridge.TAG, " onTabChanged AOP ERROR: " + e.getMessage());
            }
        }
    }

    private static boolean fragmentGetUserVisibleHint(Object obj) {
        try {
            return ((Boolean) obj.getClass().getMethod("getUserVisibleHint", new Class[0]).invoke(obj, new Object[0])).booleanValue();
        } catch (Exception unused) {
            return false;
        }
    }

    private static boolean fragmentIsNotHidden(Object obj) {
        try {
            return !((Boolean) obj.getClass().getMethod("isHidden", new Class[0]).invoke(obj, new Object[0])).booleanValue();
        } catch (Exception unused) {
            return true;
        }
    }

    private static boolean fragmentIsResumed(Object obj) {
        try {
            return ((Boolean) obj.getClass().getMethod("isResumed", new Class[0]).invoke(obj, new Object[0])).booleanValue();
        } catch (Exception unused) {
            return false;
        }
    }

    private static boolean isNotFragment(Object obj) {
        Class<?> cls;
        Class<?> cls2 = null;
        try {
            cls = Class.forName("androidx.fragment.app.Fragment");
        } catch (Exception unused) {
            cls = null;
        }
        try {
            cls2 = Class.forName("androidx.fragment.app.Fragment");
        } catch (Exception unused2) {
        }
        if (cls == null && cls2 == null) {
            return true;
        }
        if (cls != null) {
            try {
                if (cls.isInstance(obj)) {
                    return false;
                }
                if (cls2 == null && cls2.isInstance(obj)) {
                    return false;
                }
            } catch (Exception unused3) {
            }
        } else if (cls2 == null) {
        }
        return true;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static boolean isViewIgnored(ThinkingAnalyticsSDK thinkingAnalyticsSDK, View view) {
        if (view == null) {
            return true;
        }
        try {
            List<Class> ignoredViewTypeList = thinkingAnalyticsSDK.getIgnoredViewTypeList();
            if (ignoredViewTypeList != null) {
                Iterator<Class> it = ignoredViewTypeList.iterator();
                while (it.hasNext()) {
                    if (it.next().isAssignableFrom(view.getClass())) {
                        return true;
                    }
                }
            }
            return "1".equals(q.a(thinkingAnalyticsSDK.getToken(), view, R.id.thinking_analytics_tag_view_ignored));
        } catch (Exception e2) {
            e2.printStackTrace();
            return true;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static boolean isViewIgnored(ThinkingAnalyticsSDK thinkingAnalyticsSDK, Class cls) {
        if (cls == null) {
            return true;
        }
        try {
            List<Class> ignoredViewTypeList = thinkingAnalyticsSDK.getIgnoredViewTypeList();
            if (ignoredViewTypeList == null) {
                return false;
            }
            Iterator<Class> it = ignoredViewTypeList.iterator();
            while (it.hasNext()) {
                if (it.next().isAssignableFrom(cls)) {
                    return true;
                }
            }
            return false;
        } catch (Exception unused) {
            return true;
        }
    }

    public static void onAdapterViewItemClick(View view, View view2, int i2) {
        if (view == null || view2 == null || !(view instanceof AdapterView)) {
            return;
        }
        ThinkingAnalyticsSDK.allInstances(new g(view2, view, i2));
    }

    public static void onAppPushClickEvent(ThinkingAnalyticsSDK thinkingAnalyticsSDK, String str, JSONObject jSONObject) {
        if (thinkingAnalyticsSDK != null) {
            thinkingAnalyticsSDK.autoTrack(str, jSONObject);
            thinkingAnalyticsSDK.flush();
        }
    }

    public static void onDialogClick(Object obj, int i2) {
        if (obj instanceof Dialog) {
            ThinkingAnalyticsSDK.allInstances(new f((Dialog) obj, i2));
        }
    }

    public static void onExpandableListViewOnChildClick(View view, View view2, int i2, int i3) {
        Context context;
        if (view == null || (context = view.getContext()) == null) {
            return;
        }
        ThinkingAnalyticsSDK.allInstances(new e(context, view, view2, i3, i2));
    }

    public static void onExpandableListViewOnGroupClick(View view, View view2, int i2) {
        onExpandableListViewOnChildClick(view, view2, i2, -1);
    }

    public static void onFragmentCreateView(Object obj, View view) {
        try {
            if (isNotFragment(obj)) {
                return;
            }
            String name = obj.getClass().getName();
            view.setTag(R.id.thinking_analytics_tag_view_fragment_name, name);
            if (view instanceof ViewGroup) {
                traverseView(name, (ViewGroup) view);
            }
        } catch (Exception e2) {
            e2.printStackTrace();
        }
    }

    public static void onFragmentHiddenChanged(Object obj, boolean z) {
        Object objInvoke;
        if (isNotFragment(obj)) {
            return;
        }
        try {
            objInvoke = obj.getClass().getMethod("getParentFragment", new Class[0]).invoke(obj, new Object[0]);
        } catch (Exception unused) {
            objInvoke = null;
        }
        if (z) {
            return;
        }
        if ((objInvoke == null && fragmentIsResumed(obj) && fragmentIsNotHidden(obj)) || (fragmentIsResumed(obj) && fragmentIsNotHidden(obj) && fragmentGetUserVisibleHint(obj))) {
            trackFragmentViewScreen(obj);
        }
    }

    public static void onFragmentOnResume(Object obj) {
        Object objInvoke;
        if (isNotFragment(obj)) {
            return;
        }
        try {
            objInvoke = obj.getClass().getMethod("getParentFragment", new Class[0]).invoke(obj, new Object[0]);
        } catch (Exception unused) {
            objInvoke = null;
        }
        if (objInvoke == null) {
            if (!fragmentIsNotHidden(obj) || !fragmentGetUserVisibleHint(obj)) {
                return;
            }
        } else if (!fragmentIsNotHidden(obj) || !fragmentGetUserVisibleHint(obj) || !fragmentIsNotHidden(objInvoke) || !fragmentGetUserVisibleHint(objInvoke)) {
            return;
        }
        trackFragmentViewScreen(obj);
    }

    public static void onFragmentSetUserVisibleHint(Object obj, boolean z) {
        Object objInvoke;
        if (isNotFragment(obj)) {
            return;
        }
        try {
            objInvoke = obj.getClass().getMethod("getParentFragment", new Class[0]).invoke(obj, new Object[0]);
        } catch (Exception unused) {
            objInvoke = null;
        }
        if (z) {
            if ((objInvoke == null && fragmentIsResumed(obj) && fragmentIsNotHidden(obj)) || (fragmentIsResumed(obj) && fragmentIsNotHidden(obj) && fragmentGetUserVisibleHint(obj))) {
                trackFragmentViewScreen(obj);
            }
        }
    }

    public static void onMenuItemSelected(Object obj, MenuItem menuItem) {
        if (menuItem == null) {
            return;
        }
        ThinkingAnalyticsSDK.allInstances(new h(obj, menuItem));
    }

    public static void onTabHostChanged(String str) {
        ThinkingAnalyticsSDK.allInstances(new i(str));
    }

    public static void onViewOnClick(View view, Object obj) {
        if (view == null) {
            return;
        }
        ThinkingAnalyticsSDK.allInstances(new d(obj, view));
    }

    public static void trackEvent(Object obj) {
        if (obj instanceof ThinkingDataTrackEvent) {
            ThinkingDataTrackEvent thinkingDataTrackEvent = (ThinkingDataTrackEvent) obj;
            String strEventName = thinkingDataTrackEvent.eventName();
            String strProperties = thinkingDataTrackEvent.properties();
            String strAppId = thinkingDataTrackEvent.appId();
            if (TextUtils.isEmpty(strEventName)) {
                return;
            }
            JSONObject jSONObject = new JSONObject();
            if (!TextUtils.isEmpty(strProperties)) {
                try {
                    q.a(new JSONObject(strProperties), jSONObject, (TimeZone) null);
                } catch (JSONException e2) {
                    TDLog.e(TAG, "Exception occurred in trackEvent");
                    e2.printStackTrace();
                }
            }
            ThinkingAnalyticsSDK.allInstances(new b(strAppId, strEventName, jSONObject));
        }
    }

    public static void trackEvent(String str, String str2, String str3) {
        if (TextUtils.isEmpty(str)) {
            return;
        }
        JSONObject jSONObject = new JSONObject();
        if (!TextUtils.isEmpty(str2)) {
            try {
                q.a(new JSONObject(str2), jSONObject, (TimeZone) null);
            } catch (JSONException e2) {
                TDLog.e(TAG, "Exception occurred in trackEvent");
                e2.printStackTrace();
            }
        }
        ThinkingAnalyticsSDK.allInstances(new c(str3, str, jSONObject));
    }

    private static void trackFragmentViewScreen(Object obj) {
        ThinkingAnalyticsSDK.allInstances(new a(obj));
    }

    private static void traverseView(String str, ViewGroup viewGroup) {
        try {
            if (TextUtils.isEmpty(str) || viewGroup == null) {
                return;
            }
            int childCount = viewGroup.getChildCount();
            for (int i2 = 0; i2 < childCount; i2++) {
                View childAt = viewGroup.getChildAt(i2);
                childAt.setTag(R.id.thinking_analytics_tag_view_fragment_name, str);
                if (childAt instanceof ViewGroup) {
                    traverseView(str, (ViewGroup) childAt);
                }
            }
        } catch (Exception e2) {
            e2.printStackTrace();
        }
    }
}
