package com.kwad.components.core.innerEc.live.b.c;

import android.os.Handler;
import android.os.Looper;
import android.text.TextUtils;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.inputmethod.InputMethodManager;
import android.widget.EditText;
import androidx.recyclerview.widget.RecyclerView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.core.innerEc.live.base.QLiveMessage;
import com.kwad.components.core.innerEc.live.base.UserInfo;
import com.kwad.components.core.innerEc.live.comment.history.HistoryCommentsResponse;
import com.kwad.components.core.innerEc.live.comment.sendcomment.LiveSendCommentResponse;
import com.kwad.components.core.innerEc.live.widget.LiveCommentsView;
import com.kwad.components.core.innerEc.live.widget.OverScrollLayout;
import com.kwad.components.core.innerEc.live.widget.p;
import com.kwad.components.offline.api.core.adInnerEc.fullAdLive.model.PbCommentFeed;
import com.kwad.components.offline.api.core.adInnerEc.fullAdLive.model.PbSCFeedPush;
import com.kwad.components.offline.api.core.adInnerEc.fullAdLive.model.PbSystemNoticeFeed;
import com.kwad.components.offline.api.core.adInnerEc.longconnection.listener.SCMessageListener;
import com.kwad.sdk.R;
import com.kwad.sdk.utils.ae;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.util.ArrayList;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class c extends com.kwad.components.core.innerEc.live.b.a.a {
    private EditText VA;
    private View VB;
    private View VC;
    private ViewGroup VD;
    private OverScrollLayout Vi;
    private LiveCommentsView Vj;
    private com.kwad.components.core.innerEc.live.widget.h Vk;
    private com.kwad.components.core.innerEc.live.widget.f Vl;
    private com.kwad.components.core.innerEc.live.widget.j Vs;
    private com.kwad.components.core.innerEc.live.comment.history.b Vu;
    private com.kwad.components.core.innerEc.live.comment.sendcomment.b Vw;
    private ViewGroup Vz;
    private Handler jc = new Handler(Looper.getMainLooper());
    private int Vm = 0;
    private int Vn = 8;
    private boolean Vo = false;
    private List<String> Vp = new ArrayList();
    private boolean Vq = true;
    private boolean Vr = false;
    private int Vt = 0;
    private boolean Vv = false;
    private List<com.kwad.components.core.innerEc.live.widget.c> Vx = new ArrayList();
    private final Object Vy = new Object();
    private boolean VE = false;
    private com.kwad.components.core.innerEc.live.config.a Vg = new com.kwad.components.core.innerEc.live.config.a() { // from class: com.kwad.components.core.innerEc.live.b.c.c.5
        @Override // com.kwad.components.core.innerEc.live.config.a
        public final void a(com.kwad.components.core.innerEc.live.config.net.g gVar) {
        }

        @Override // com.kwad.components.core.innerEc.live.config.a
        public final void b(com.kwad.components.core.innerEc.live.config.net.g gVar) {
            c.this.VE = gVar.Uz.Up.Uw;
        }
    };
    private SCMessageListener VF = new com.kwad.components.core.innerEc.live.g.c() { // from class: com.kwad.components.core.innerEc.live.b.c.c.6
        /* JADX INFO: Access modifiers changed from: private */
        @Override // com.kwad.components.core.innerEc.live.g.a
        /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
        public void g(PbSCFeedPush pbSCFeedPush) {
            if (pbSCFeedPush == null) {
                com.kwad.sdk.core.d.c.w("LiveAdCommentsPresenter", "scFeedPush is null");
                return;
            }
            List<PbSystemNoticeFeed> systemNoticeFeeds = pbSCFeedPush.getSystemNoticeFeeds();
            if (!c.this.Vo && systemNoticeFeeds != null && systemNoticeFeeds.size() > 0) {
                c.b(c.this, true);
                c.this.a(new com.kwad.components.core.innerEc.live.widget.c(com.kwad.components.core.innerEc.live.comment.a.a(c.this.getContext(), c.a(c.this, systemNoticeFeeds.get(0).getContent(), "")), 1), false);
            }
            List<PbCommentFeed> commentFeeds = pbSCFeedPush.getCommentFeeds();
            if (commentFeeds == null || commentFeeds.size() <= 0) {
                return;
            }
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < commentFeeds.size(); i++) {
                PbCommentFeed pbCommentFeed = commentFeeds.get(i);
                if (!c.this.Vp.contains(pbCommentFeed.getCommentId())) {
                    c.this.Vp.add(pbCommentFeed.getCommentId());
                    arrayList.add(new com.kwad.components.core.innerEc.live.widget.c(com.kwad.components.core.innerEc.live.comment.a.a(c.this.getContext(), c.a(c.this, pbCommentFeed.getContent(), pbCommentFeed.getUser().getUserName()))));
                }
            }
            c.this.a((List<com.kwad.components.core.innerEc.live.widget.c>) arrayList, true);
        }
    };
    private com.kwad.components.core.innerEc.live.comment.history.b.a VG = new com.kwad.components.core.innerEc.live.comment.history.b.a() { // from class: com.kwad.components.core.innerEc.live.b.c.c.7
        @Override // com.kwad.components.core.innerEc.live.comment.history.b.a
        public final void c(HistoryCommentsResponse historyCommentsResponse) {
            if (historyCommentsResponse != null && !historyCommentsResponse.historyFeedList.isEmpty()) {
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < historyCommentsResponse.historyFeedList.size(); i++) {
                    PbCommentFeed pbCommentFeed = historyCommentsResponse.historyFeedList.get(i);
                    if (!c.this.Vp.contains(pbCommentFeed.getCommentId())) {
                        c.this.Vp.add(pbCommentFeed.getCommentId());
                        arrayList.add(new com.kwad.components.core.innerEc.live.widget.c(com.kwad.components.core.innerEc.live.comment.a.a(c.this.getContext(), c.a(c.this, pbCommentFeed.getContent(), pbCommentFeed.getUser().getUserName()))));
                    }
                }
                c.this.Vk.p(arrayList);
            }
            c.c(c.this, true);
            c.this.sd();
            c.this.Vk.notifyDataSetChanged();
        }

        @Override // com.kwad.components.core.innerEc.live.comment.history.b.a
        public final void rO() {
            c.c(c.this, true);
            c.this.sd();
        }
    };
    private com.kwad.components.core.innerEc.live.comment.sendcomment.b.a VH = new com.kwad.components.core.innerEc.live.comment.sendcomment.b.a() { // from class: com.kwad.components.core.innerEc.live.b.c.c.8
        @Override // com.kwad.components.core.innerEc.live.comment.sendcomment.b.a
        public final void a(LiveSendCommentResponse liveSendCommentResponse, com.kwad.components.core.innerEc.live.base.b bVar) {
            if ((liveSendCommentResponse != null && liveSendCommentResponse.commentCode == 228205) || liveSendCommentResponse == null || TextUtils.isEmpty(liveSendCommentResponse.commentId)) {
                return;
            }
            ae.U(c.this.getContext(), "评论成功");
            if (c.this.Vp.contains(liveSendCommentResponse.commentId)) {
                return;
            }
            c.this.Vp.add(liveSendCommentResponse.commentId);
            c.this.a(new com.kwad.components.core.innerEc.live.widget.c(com.kwad.components.core.innerEc.live.comment.a.a(c.this.getContext(), c.a(c.this, bVar.content, c.this.sc()))));
        }
    };

    static /* synthetic */ QLiveMessage a(c cVar, String str, String str2) {
        return m(str, str2);
    }

    static /* synthetic */ boolean b(c cVar, boolean z) {
        cVar.Vo = true;
        return true;
    }

    static /* synthetic */ boolean c(c cVar, boolean z) {
        cVar.Vv = true;
        return true;
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.VD = (ViewGroup) findViewById(R.id.ksad_live_ad_container);
        View viewInflate = LayoutInflater.from(getContext()).inflate(R.layout.ksad_live_comments_layout, (ViewGroup) null);
        this.VC = viewInflate;
        OverScrollLayout overScrollLayout = (OverScrollLayout) viewInflate.findViewById(R.id.ksad_live_comments_container);
        this.Vi = overScrollLayout;
        overScrollLayout.setOverScrollType(OverScrollLayout.OverScrollType.ONLY_DOWN_DRAG);
        LiveCommentsView liveCommentsView = (LiveCommentsView) this.VC.findViewById(R.id.ksad_live_comments_recyclerview);
        this.Vj = liveCommentsView;
        liveCommentsView.addOnScrollListener(new RecyclerView.OnScrollListener() { // from class: com.kwad.components.core.innerEc.live.b.c.c.1
            public final void onScrollStateChanged(RecyclerView recyclerView, int i) {
                super.onScrollStateChanged(recyclerView, i);
                c.this.Vt = i;
                c.this.se();
            }

            public final void onScrolled(RecyclerView recyclerView, int i, int i2) {
                super.onScrolled(recyclerView, i, i2);
                if (i2 >= 0 || c.this.Vt != 1) {
                    return;
                }
                c.this.sg();
                c.this.Vl.aL(false);
            }
        });
        ViewGroup viewGroup = (ViewGroup) findViewById(R.id.comment_edit_root);
        this.Vz = viewGroup;
        viewGroup.setVisibility(8);
        this.VA = (EditText) findViewById(R.id.ksad_comment_edit);
        View viewFindViewById = findViewById(R.id.ksad_comment_send);
        this.VB = viewFindViewById;
        viewFindViewById.setOnClickListener(new com.kwad.components.core.innerEc.live.i.b(new View.OnClickListener() { // from class: com.kwad.components.core.innerEc.live.b.c.c.2
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                String string = c.this.VA.getText().toString();
                if (TextUtils.isEmpty(string)) {
                    ae.c(c.this.getContext(), "说点什么吧~", 0);
                    return;
                }
                c.this.Vw.a(string, c.this.VH);
                c.this.so();
                c.this.VA.setText("");
                c.this.Vz.setVisibility(8);
            }
        }));
        sl();
        com.kwad.components.core.innerEc.live.widget.h hVar = new com.kwad.components.core.innerEc.live.widget.h();
        this.Vk = hVar;
        this.Vj.setAdapter(hVar);
        sm();
    }

    @Override // com.kwad.components.core.innerEc.live.b.a.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.Uj.UX.add(new com.kwad.sdk.g.b<Object, Object>() { // from class: com.kwad.components.core.innerEc.live.b.c.c.3
            @Override // com.kwad.sdk.g.b
            public final Object apply(Object obj) {
                c cVar = c.this;
                View viewC = cVar.c(cVar.VD, "commentContainer");
                com.kwad.sdk.core.d.c.d("LiveAdCommentsPresenter", "find commentContainer view: " + viewC);
                if (viewC == null || !(viewC instanceof ViewGroup)) {
                    return null;
                }
                p.b((ViewGroup) viewC, c.this.VC);
                return null;
            }
        });
        this.Uj.UY = new com.kwad.sdk.g.b<Object, Object>() { // from class: com.kwad.components.core.innerEc.live.b.c.c.4
            @Override // com.kwad.sdk.g.b
            public final Object apply(Object obj) {
                c.this.Vk.notifyDataSetChanged();
                return null;
            }
        };
        com.kwad.components.core.innerEc.live.widget.i iVar = new com.kwad.components.core.innerEc.live.widget.i();
        iVar.Zu = true;
        this.Vs = new com.kwad.components.core.innerEc.live.widget.j(iVar, this.Vj, getActivity());
        this.Uj.UU = this.Vk;
        com.kwad.components.core.innerEc.live.comment.history.b bVar = new com.kwad.components.core.innerEc.live.comment.history.b(this.Uj.mAdTemplate);
        this.Vu = bVar;
        bVar.a(this.VG);
        this.Vu.rM();
        this.Vw = new com.kwad.components.core.innerEc.live.comment.sendcomment.b(this.Uj.mAdTemplate);
        this.Uj.UQ.registerSCMessageListener(this.VF);
        this.Uj.UN.a(this.Vg);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.Vu.b(this.VG);
        so();
        synchronized (this.Vy) {
            this.Vx.clear();
        }
        this.Uj.UQ.unregisterSCMessageListener(this.VF);
        this.Vp.clear();
        this.Uj.UN.b(this.Vg);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onDestroy() {
        super.onDestroy();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public String sc() {
        String strRd = com.kwad.components.core.innerEc.e.re().rd();
        if (TextUtils.isEmpty(strRd)) {
            return "广告联盟用户";
        }
        return this.VE ? strRd.substring(0, 1) + "***" : strRd;
    }

    private static QLiveMessage m(String str, String str2) {
        QLiveMessage qLiveMessage = new QLiveMessage();
        qLiveMessage.content = str;
        qLiveMessage.user = new UserInfo();
        qLiveMessage.user.userName = str2;
        return qLiveMessage;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void sd() {
        synchronized (this.Vy) {
            if (!this.Vx.isEmpty()) {
                this.Vk.p(new ArrayList(this.Vx));
                this.Vx.clear();
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(com.kwad.components.core.innerEc.live.widget.c cVar, boolean z) {
        if (z && !this.Vv) {
            synchronized (this.Vy) {
                this.Vx.add(cVar);
            }
        } else {
            this.Vk.b(cVar);
            if (z) {
                a(com.kwad.components.core.innerEc.live.widget.g.c.Zh);
                sj();
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(List<com.kwad.components.core.innerEc.live.widget.c> list, boolean z) {
        if (z && !this.Vv) {
            synchronized (this.Vy) {
                this.Vx.addAll(list);
            }
        } else {
            this.Vk.p(list);
            if (z) {
                a(com.kwad.components.core.innerEc.live.widget.g.c.Zh);
                sj();
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void se() {
        if (this.Vt == 0) {
            if (sk()) {
                sh();
                return;
            } else {
                si();
                return;
            }
        }
        sf();
    }

    private void sf() {
        by.s(this);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void sg() {
        this.Vq = false;
    }

    private void sh() {
        this.Vq = true;
    }

    private void si() {
        if (!this.Vr || this.Vq) {
            by.a(new bi() { // from class: com.kwad.components.core.innerEc.live.b.c.c.9
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    c.this.sj();
                }
            }, this, 5000L);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void sj() {
        RecyclerView.Adapter adapter;
        int itemCount;
        if (sn() || this.Vs.tl() || (adapter = this.Vj.getAdapter()) == null || (itemCount = adapter.getItemCount()) <= 0) {
            return;
        }
        this.Vj.smoothScrollToPosition(itemCount - 1);
    }

    private boolean sk() {
        if (this.Vj.getChildCount() == 0 || this.Vj.getAdapter() == null) {
            return true;
        }
        LiveCommentsView liveCommentsView = this.Vj;
        View childAt = liveCommentsView.getChildAt(liveCommentsView.getChildCount() - 1);
        return (childAt.getBottom() - this.Vn <= this.Vj.getHeight() - this.Vj.getPaddingBottom()) && this.Vj.getChildAdapterPosition(childAt) == this.Vj.getAdapter().getItemCount() - 1;
    }

    private void sl() {
        com.kwad.components.core.innerEc.live.widget.f fVar = new com.kwad.components.core.innerEc.live.widget.f(this.Vj);
        this.Vl = fVar;
        fVar.setOrientation(1);
        this.Vl.setStackFromEnd(true);
        this.Vl.a(new com.kwad.components.core.innerEc.live.widget.f.a(true, MediaPlayer.MEDIA_PLAYER_OPTION_TT_HLS_DRM, 200));
        this.Vl.aL(true);
        this.Vj.setLayoutManager(this.Vl);
    }

    private void sm() {
        this.Vj.setCustomFadingEdgeLength(com.kwad.sdk.c.a.a.a(getContext(), 24.0f));
        this.Vj.setCustomFadingEdgeTop(0);
    }

    private void a(com.kwad.components.core.innerEc.live.widget.g gVar) {
        this.Vl.b(gVar);
    }

    private boolean sn() {
        return this.Vl.te() instanceof com.kwad.components.core.innerEc.live.widget.g.e;
    }

    public final void so() {
        this.Vz.setVisibility(8);
        try {
            ((InputMethodManager) getContext().getSystemService("input_method")).hideSoftInputFromWindow(this.Vz.getWindowToken(), 2);
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.printStackTraceOnly(th);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public View c(View view, String str) {
        if (!(view instanceof ViewGroup)) {
            return null;
        }
        ViewGroup viewGroup = (ViewGroup) view;
        for (int i = 0; i < viewGroup.getChildCount(); i++) {
            View childAt = viewGroup.getChildAt(i);
            if (childAt.getContentDescription() != null && childAt.getContentDescription().toString().contains(str)) {
                return childAt;
            }
            View viewC = c(childAt, str);
            if (viewC != null) {
                return viewC;
            }
        }
        return null;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(com.kwad.components.core.innerEc.live.widget.c cVar) {
        a(cVar, true);
    }
}
