package com.sigmob.sdk.nativead;

import android.app.Activity;
import android.app.Dialog;
import android.content.Context;
import android.content.DialogInterface;
import android.graphics.Color;
import android.os.Bundle;
import android.os.Handler;
import android.text.Editable;
import android.text.TextUtils;
import android.text.TextWatcher;
import android.util.Base64;
import android.view.View;
import android.view.ViewGroup;
import android.view.Window;
import android.view.WindowManager;
import android.widget.EditText;
import android.widget.TextView;
import com.czhj.sdk.common.ThreadPool.ThreadPoolFactory;
import com.czhj.sdk.common.network.Networking;
import com.czhj.sdk.common.network.SigmobRequestQueue;
import com.czhj.sdk.common.utils.Dips;
import com.czhj.sdk.common.utils.ResourceUtil;
import com.czhj.sdk.logger.SigmobLog;
import com.czhj.volley.VolleyError;
import com.sigmob.sdk.base.common.ak;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.rtb.BidResponse;
import com.sigmob.sdk.base.mta.PointCategory;
import com.sigmob.sdk.base.mta.PointEntitySigmob;
import com.sigmob.windad.WindAds;
import com.sigmob.windad.natives.WindNativeAdData;
import java.lang.ref.SoftReference;
import java.util.ArrayList;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public class b extends Dialog implements DialogInterface.OnDismissListener, DialogInterface.OnShowListener, View.OnClickListener, v {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final String f3571a = "DisLikeDialog";
    private final SoftReference<Context> b;
    private final Context c;
    private final BaseAdUnit d;
    private WindNativeAdData.DislikeInteractionCallback e;
    private final List<String> f;
    private TextView g;
    private TextView h;
    private TextView i;
    private TextView j;
    private EditText k;
    private q l;

    /* JADX INFO: renamed from: com.sigmob.sdk.nativead.b$1, reason: invalid class name */
    class AnonymousClass1 implements com.sigmob.sdk.base.network.d.a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ Context f3572a;

        AnonymousClass1(final Context val$context) {
            this.f3572a = val$context;
        }

        /* JADX INFO: Access modifiers changed from: private */
        public static /* synthetic */ void a(Context context) {
            ak.a(context, "反馈上报成功", 0).show();
        }

        /* JADX INFO: Access modifiers changed from: private */
        public static /* synthetic */ void a(VolleyError volleyError, Context context) {
            ak.a(context, "反馈上报失败，错误码: " + ((volleyError == null || volleyError.networkResponse == null) ? 0 : volleyError.networkResponse.statusCode), 1).show();
        }

        @Override // com.sigmob.sdk.base.network.d.a
        public void a(JSONObject response) {
            Handler handler = WindAds.sharedAds().getHandler();
            final Context context = this.f3572a;
            handler.post(new Runnable() { // from class: com.sigmob.sdk.nativead.b$1$$ExternalSyntheticLambda0
                @Override // java.lang.Runnable
                public final void run() {
                    b.AnonymousClass1.a(context);
                }
            });
        }

        @Override // com.czhj.volley.Response.ErrorListener
        public void onErrorResponse(final VolleyError error) {
            Handler handler = WindAds.sharedAds().getHandler();
            final Context context = this.f3572a;
            handler.post(new Runnable() { // from class: com.sigmob.sdk.nativead.b$1$$ExternalSyntheticLambda1
                @Override // java.lang.Runnable
                public final void run() {
                    b.AnonymousClass1.a(error, context);
                }
            });
        }
    }

    public b(Context context, BaseAdUnit adUnit) {
        super(context, com.sigmob.sdk.base.k.e());
        this.f = new ArrayList();
        this.b = new SoftReference<>(context);
        this.c = context.getApplicationContext();
        this.d = adUnit;
        c();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(int i, String str) {
        d();
        a("dislike", PointCategory.REPORT, String.valueOf(i), "");
        WindNativeAdData.DislikeInteractionCallback dislikeInteractionCallback = this.e;
        if (dislikeInteractionCallback == null) {
            return;
        }
        dislikeInteractionCallback.onSelected(4, str, true);
        dismiss();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(View view) {
        dismiss();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(BidResponse bidResponse, Context context) {
        com.sigmob.sdk.base.network.d dVar = new com.sigmob.sdk.base.network.d(com.sigmob.sdk.base.o.a().s(), bidResponse, new AnonymousClass1(context));
        SigmobRequestQueue sigRequestQueue = Networking.getSigRequestQueue();
        if (sigRequestQueue == null) {
            return;
        }
        sigRequestQueue.add(dVar);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(String str, String str2, Object obj) {
        if (obj instanceof PointEntitySigmob) {
            PointEntitySigmob pointEntitySigmob = (PointEntitySigmob) obj;
            pointEntitySigmob.setAdtype(String.valueOf(this.d.getAd_type()));
            pointEntitySigmob.setLoad_id(this.d.getLoad_id());
            pointEntitySigmob.setRequest_id(this.d.getRequestId());
            pointEntitySigmob.setReason(str);
            pointEntitySigmob.setContent(str2);
            pointEntitySigmob.setVid(this.d.getVid());
        }
    }

    private void a(String cate, String sub_category, final String reason, final String content) {
        com.sigmob.sdk.base.common.ad.a(cate, sub_category, this.d, new com.sigmob.sdk.base.common.ad.a() { // from class: com.sigmob.sdk.nativead.b$$ExternalSyntheticLambda4
            @Override // com.sigmob.sdk.base.common.ad.a
            public final void onAddExtra(Object obj) {
                this.f$0.a(reason, content, obj);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ boolean b(View view) {
        Context context;
        BaseAdUnit baseAdUnit = this.d;
        if (baseAdUnit == null) {
            return false;
        }
        String str = "广告请求 ID\n" + baseAdUnit.getRequestId();
        SoftReference<Context> softReference = this.b;
        if (softReference != null && (context = softReference.get()) != null && (context instanceof Activity)) {
            Activity activity = (Activity) context;
            if (!activity.isFinishing() && !activity.isDestroyed()) {
                new c(activity, str).show();
                return true;
            }
        }
        return false;
    }

    private void c() {
        this.f.clear();
        this.f.add("违法违规");
        this.f.add("疑似抄袭");
        this.f.add("虚假欺诈");
        this.f.add("低俗色情");
        this.f.add("诱导点击");
    }

    private void d() {
        final Context contextE = com.sigmob.sdk.b.e();
        BaseAdUnit baseAdUnit = this.d;
        if (baseAdUnit == null) {
            ak.a(contextE, "感谢反馈", 0).show();
            return;
        }
        baseAdUnit.dislikeReport();
        if (!com.sigmob.sdk.base.o.a().g()) {
            ak.a(contextE, "感谢反馈", 0).show();
            return;
        }
        final BidResponse bidResponseA = com.sigmob.sdk.base.common.h.a(this.d.getRequestId());
        if (bidResponseA == null) {
            return;
        }
        ThreadPoolFactory.BackgroundThreadPool.getInstance().submit(new Runnable() { // from class: com.sigmob.sdk.nativead.b$$ExternalSyntheticLambda3
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.a(bidResponseA, contextE);
            }
        });
    }

    private void e() {
        int i;
        Window window = getWindow();
        Context context = getContext();
        if (window == null) {
            return;
        }
        window.setGravity(17);
        window.getDecorView().setPadding(0, 0, 0, 0);
        WindowManager.LayoutParams attributes = window.getAttributes();
        int i2 = context.getResources().getDisplayMetrics().widthPixels;
        int i3 = context.getResources().getDisplayMetrics().heightPixels;
        int iDipsToIntPixels = Dips.dipsToIntPixels(0.0f, context);
        int i4 = -1;
        if (i3 > i2) {
            i = -1;
            i4 = i2 - iDipsToIntPixels;
        } else {
            i = i3 - iDipsToIntPixels;
        }
        attributes.width = i4;
        attributes.height = i;
        window.setAttributes(attributes);
        int iG = com.sigmob.sdk.base.k.g();
        if (iG <= 0) {
            return;
        }
        window.setWindowAnimations(iG);
    }

    @Override // com.sigmob.sdk.nativead.v
    public void a() {
        BaseAdUnit baseAdUnit = this.d;
        if (baseAdUnit == null || (baseAdUnit.isDislikeReported() && this.d.getAd_type() != 5)) {
            ak.a(getContext(), "已提交反馈", 0).show();
        } else {
            show();
            a("dislike", "click", "", "");
        }
    }

    @Override // com.sigmob.sdk.nativead.v
    public void a(WindNativeAdData.DislikeInteractionCallback callback) {
        this.e = callback;
    }

    public void b() {
        TextView textView = this.g;
        if (textView != null) {
            textView.setOnClickListener(null);
            this.g = null;
        }
        TextView textView2 = this.h;
        if (textView2 != null) {
            textView2.setOnClickListener(null);
            this.h = null;
        }
        TextView textView3 = this.i;
        if (textView3 != null) {
            textView3.setOnClickListener(null);
            this.i = null;
        }
        TextView textView4 = this.j;
        if (textView4 != null) {
            textView4.setOnClickListener(null);
            this.j = null;
        }
        if (this.e != null) {
            this.e = null;
        }
        setOnShowListener(null);
        setOnDismissListener(null);
    }

    @Override // android.view.View.OnClickListener
    public void onClick(View v) {
        int i;
        String string;
        String str = "";
        if (v.equals(this.h)) {
            String str2 = (String) this.h.getText();
            a("dislike", PointCategory.ABNORMAL_SHOW, "", "");
            str = str2;
            i = 1;
        } else {
            if (v.equals(this.i)) {
                string = (String) this.i.getText();
                a("dislike", PointCategory.CANNOT_CLOSE, "", "");
                i = 2;
            } else if (v.equals(this.g)) {
                string = (String) this.g.getText();
                a("dislike", PointCategory.NOINTEREST_CLICK, "", "");
                i = 3;
            } else {
                i = 0;
                if (v.equals(this.j) && com.sigmob.sdk.base.utils.v.b(this.k)) {
                    string = this.k.getText().toString();
                    if (TextUtils.isEmpty(string)) {
                        ak.a(com.sigmob.sdk.b.e(), "请输入反馈文字", 0).show();
                        return;
                    } else {
                        a("dislike", PointCategory.ADVICE, "", Base64.encodeToString(string.getBytes(), 0));
                        i = 5;
                    }
                }
            }
            str = string;
        }
        d();
        WindNativeAdData.DislikeInteractionCallback dislikeInteractionCallback = this.e;
        if (dislikeInteractionCallback == null || i == 0) {
            return;
        }
        dislikeInteractionCallback.onSelected(i, str, true);
        dismiss();
    }

    @Override // android.app.Dialog
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(ResourceUtil.getLayoutId(this.c, "sig_dislike_layout"));
        View viewFindViewById = findViewById(ResourceUtil.getId(this.c, "sig_dislike_sv"));
        ViewGroup viewGroup = (ViewGroup) findViewById(ResourceUtil.getId(this.c, "sig_dislike_ll"));
        viewGroup.setLongClickable(true);
        viewGroup.setOnLongClickListener(new View.OnLongClickListener() { // from class: com.sigmob.sdk.nativead.b$$ExternalSyntheticLambda0
            @Override // android.view.View.OnLongClickListener
            public final boolean onLongClick(View view) {
                return this.f$0.b(view);
            }
        });
        this.h = (TextView) findViewById(ResourceUtil.getId(this.c, "sig_not_show_tv"));
        this.i = (TextView) findViewById(ResourceUtil.getId(this.c, "sig_not_close_tv"));
        this.g = (TextView) findViewById(ResourceUtil.getId(this.c, "sig_dislike_tv"));
        this.j = (TextView) findViewById(ResourceUtil.getId(this.c, "sig_commit_sl"));
        this.k = (EditText) findViewById(ResourceUtil.getId(this.c, "sig_suggest_et"));
        viewFindViewById.setOnClickListener(new View.OnClickListener() { // from class: com.sigmob.sdk.nativead.b$$ExternalSyntheticLambda1
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                this.f$0.a(view);
            }
        });
        this.g.setOnClickListener(this);
        this.h.setOnClickListener(this);
        this.i.setOnClickListener(this);
        this.j.setOnClickListener(this);
        this.k.addTextChangedListener(new TextWatcher() { // from class: com.sigmob.sdk.nativead.b.2
            @Override // android.text.TextWatcher
            public void afterTextChanged(Editable edit) {
                if (TextUtils.isEmpty(edit.toString()) && com.sigmob.sdk.base.utils.v.b(b.this.j)) {
                    b.this.j.setTextColor(Color.parseColor("#C2C2C2"));
                }
            }

            @Override // android.text.TextWatcher
            public void beforeTextChanged(CharSequence text, int start, int count, int after) {
            }

            @Override // android.text.TextWatcher
            public void onTextChanged(CharSequence text, int start, int before, int count) {
                if (b.this.j == null) {
                    return;
                }
                b.this.j.setTextColor(Color.parseColor("#FE7E03"));
            }
        });
        q qVar = new q(this.c);
        this.l = qVar;
        qVar.setList(this.f);
        this.l.setOnItemClickListener(new q.e() { // from class: com.sigmob.sdk.nativead.b$$ExternalSyntheticLambda2
            @Override // com.sigmob.sdk.nativead.q.e
            public final void onItemClick(int i, String str) {
                this.f$0.a(i, str);
            }
        });
        ((ViewGroup) findViewById(ResourceUtil.getId(this.c, "sig_flow_sl"))).addView(this.l, new ViewGroup.LayoutParams(-1, -2));
        setOnShowListener(this);
        setOnDismissListener(this);
        setCanceledOnTouchOutside(true);
        setCancelable(true);
        e();
    }

    @Override // android.content.DialogInterface.OnDismissListener
    public void onDismiss(DialogInterface dialog) {
        SigmobLog.i("DisLikeDialog#onDismiss");
        WindNativeAdData.DislikeInteractionCallback dislikeInteractionCallback = this.e;
        if (dislikeInteractionCallback == null) {
            return;
        }
        dislikeInteractionCallback.onCancel();
    }

    @Override // android.content.DialogInterface.OnShowListener
    public void onShow(DialogInterface dialog) {
        SigmobLog.i("DisLikeDialog#onShow");
        WindNativeAdData.DislikeInteractionCallback dislikeInteractionCallback = this.e;
        if (dislikeInteractionCallback != null) {
            dislikeInteractionCallback.onShow();
        }
        q qVar = this.l;
        if (qVar != null) {
            qVar.b();
        }
    }
}
